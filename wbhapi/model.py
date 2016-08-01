#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""
This module defines the data schema.
"""

from collections import OrderedDict
from sfm import nameddict
from marshmallow import Schema, fields, post_load


#--- OBS API ---
class EnStation(nameddict.Base):
    __attrs__ = [
        "provider_id", "provider_name", "station_id", "station_name",
        "latitude", "longitude", "display_flag",
        "elevation_above_sea_level_meters", "time_zone", "inactive",
    ]

    def __init__(self, **kwargs):
        self.provider_id = kwargs.get("provider_id")
        self.provider_name = kwargs.get("provider_name")
        self.station_id = kwargs.get("station_id")
        self.station_name = kwargs.get("station_name")
        self.latitude = kwargs.get("latitude")
        self.longitude = kwargs.get("longitude")
        self.display_flag = kwargs.get("display_flag")
        self.elevation_above_sea_level_meters = kwargs.get(
            "elevation_above_sea_level_meters")
        self.time_zone = kwargs.get("time_zone")
        self.inactive = kwargs.get("inactive")


class EnStationSchema(Schema):
    provider_id = fields.Integer(load_from="pid")
    provider_name = fields.String(load_from="pn")
    station_id = fields.String(load_from="sid")
    station_name = fields.String(load_from="sn")
    latitude = fields.Number(load_from="lat")
    longitude = fields.Number(load_from="lon")
    display_flag = fields.Integer(load_from="df")
    elevation_above_sea_level_meters = fields.Number(load_from="el")
    time_zone = fields.String(load_from="tz")
    inactive = fields.Boolean(load_from="i")

    @post_load
    def make_en_station(self, data):
        return EnStation(**data)

#--- Observation Data Fields ---


class TemperatureC(nameddict.Base):
    __attrs__ = ["value", ]

    def __init__(self, **kwargs):
        self.value = kwargs.get("value")


class TemperatureCSchema(Schema):
    value = fields.Number(load_from="v", allow_none=True)

    @post_load
    def make_temperatureC(self, data):
        return TemperatureC(**data)


class EnObservation(nameddict.Base):
    __attrs__ = ["observation_time_utc", "temperatureC"]

    def __init__(self, **kwargs):
        self.observation_time_utc = kwargs.get("observation_time_utc")
        self.temperatureC = kwargs.get("temperatureC", TemperatureC())
        

class EnObservationSchema(Schema):
    observation_time_utc = fields.DateTime(load_from="otu")
    temperatureC = fields.Nested(TemperatureCSchema, load_from="t")

    @post_load
    def make_en_observation(self, data):
        return EnObservation(**data)


#--- Class 1 Fields ---
class HistoricalObservation(nameddict.Base):
    __attrs__ = ["observation"]

    def __init__(self, **kwargs):
        self.observation = kwargs.get("observation", EnObservation())


class HistoricalObservationSchema(Schema):
    observation = fields.Nested(EnObservationSchema, load_from="o")

    @post_load
    def make_historical_observation(self, data):
        return HistoricalObservation(**data)


class ObsResult(nameddict.Base):
    __attrs__ = ["station", "historical_observation"]

    def __init__(self, **kwargs):
        self.station = kwargs.get("station")
        self.historical_observation = kwargs.get("historical_observation")


class ResultSchema(Schema):
    station = fields.Nested(EnStationSchema, load_from="s")
    historical_observation = fields.List(
        fields.Nested(HistoricalObservationSchema), load_from="ho")

    @post_load
    def make_result(self, data):
        return ObsResult(**data)


class EnHistoricalObs(nameddict.Base):
    __attrs__ = ["id", "code", "error_message", "result"]

    def __init__(self, **kwargs):
        self.id = kwargs.get("id")
        self.code = kwargs.get("code")
        self.error_message = kwargs.get("error_message")
        self.result = kwargs.get("result", ObsResult())

    def get_core_data(self):
        """
        """
        df = OrderedDict()
        for attr in EnObservation.__attrs__:
            df[attr] = list()

        for historical_observation in self.result.historical_observation:
            observation = historical_observation.observation
            for attr in EnObservation.__attrs__:
                try:
                    df[attr].append(observation[attr].value)
                except AttributeError:
                    df[attr].append(observation[attr])

        return df


class EnHistoricalObsSchema(Schema):
    id = fields.String(load_from="i")
    code = fields.Integer(load_from="c")
    error_message = fields.String(load_from="e", allow_none=True)
    result = fields.Nested(ResultSchema, load_from="r")

    @post_load
    def make_en_historical_obs(self, data):
        return EnHistoricalObs(**data)


#--- LOAD API ---
class LoadRecord(nameddict.Base):
    __attrs__ = ["datetime_utc", "value"]

    def __init__(self, **kwargs):
        self.datetime_utc = kwargs.get("datetime_utc")
        self.value = kwargs.get("value")


class LoadRecordSchema(Schema):
    datetime_utc = fields.DateTime(load_from="DateTimeUtc")
    value = fields.Number(load_from="Value", allow_none=True)

    @post_load
    def make_load_record(self, data):
        return LoadRecord(**data)


class LoadResult(nameddict.Base):
    __attrs__ = [
        "consumer_utility_id", "period_start_utc", "period_end_utc", "records"]

    def __init__(self, **kwargs):
        self.consumer_utility_id = kwargs.get("consumer_utility_id")
        self.period_start_utc = kwargs.get("period_start_utc")
        self.period_end_utc = kwargs.get("period_end_utc")
        self.records = kwargs.get("records")


class LoadResultSchema(Schema):
    consumer_utility_id = fields.String(load_from="ConsumerUtilityId")
    period_start_utc = fields.DateTime(load_from="PeriodStartUtc")
    period_end_utc = fields.DateTime(load_from="PeriodEndUtc")
    records = fields.List(fields.Nested(LoadRecordSchema), load_from="Records")

    @post_load
    def make_load_result(self, data):
        return LoadResult(**data)


class LoadObs(nameddict.Base):
    __attrs__ = ["id", "code", "error_message", "result"]

    def __init__(self, **kwargs):
        self.id = kwargs.get("id")
        self.code = kwargs.get("code")
        self.error_message = kwargs.get("error_message")
        self.result = kwargs.get("result")

    def get_core_data(self):
        """
        """
        df = OrderedDict()
        for attr in LoadRecord.__attrs__:
            df[attr] = list()

        for load_record in self.result.records:
            for attr in LoadRecord.__attrs__:
                df[attr].append(load_record[attr])

        return df


class LoadObsSchema(Schema):
    id = fields.String(load_from="Id")
    code = fields.Integer(load_from="Code")
    error_message = fields.String(load_from="ErrorMessage", allow_none=True)
    result = fields.Nested(LoadResultSchema, load_from="Result")

    @post_load
    def make_load_obs(self, data):
        return LoadObs(**data)


#--- OTHER ---
class Loader(object):
    en_historical_obs_schema = EnHistoricalObsSchema()
    load_obs_schema = LoadObsSchema()

    @staticmethod
    def load_en_historical_obs(data):
        """

        :param data: dict like data.
        """
        return Loader.en_historical_obs_schema.load(data).data

    @staticmethod
    def load_load_obs(data):
        return Loader.load_obs_schema.load(data).data


if __name__ == "__main__":
    import json
    import requests
    import pandas as pd
    from dataIO import js
    from wbhapi import testdata

    en_historical_obs_schema = EnHistoricalObsSchema()
    en_historical_obs_data = js.load(testdata.path_obs_data)
    en_historical_obs = Loader.load_en_historical_obs(en_historical_obs_data)

    def test_en_historical_obs_model():
        assert isinstance(en_historical_obs, EnHistoricalObs)
        assert isinstance(en_historical_obs.result, ObsResult)
        assert isinstance(en_historical_obs.result.station, EnStation)
        assert isinstance(
            en_historical_obs.result.historical_observation[0], HistoricalObservation)
        assert isinstance(
            en_historical_obs.result.historical_observation[0].observation, EnObservation)
        assert isinstance(en_historical_obs.result.historical_observation[
                          0].observation.temperatureC, TemperatureC)
#         print(pd.DataFrame(en_historical_obs.get_core_data()))

    test_en_historical_obs_model()

    load_obs_schema = LoadObsSchema()
    load_obs_data = js.load(testdata.path_load_data)
    load_obs = Loader.load_load_obs(load_obs_data)

    def test_load_obs_model():
        assert isinstance(load_obs, LoadObs)
        assert isinstance(load_obs.result, LoadResult)
        assert isinstance(load_obs.result.records[0], LoadRecord)
#         print(pd.DataFrame(load_obs.get_core_data()))

    test_load_obs_model()
