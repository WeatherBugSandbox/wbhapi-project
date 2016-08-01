#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""
This module provide functional interface to get json data reponse via http
request.
"""

import json
import requests
from rolex import rolex


class Spider(object):
    obs_keyword = ["providerid", "stationid", "startdatetimeutc",
                   "enddatetimeutc", "compact", "includeRsVersion"]
    obs_endpoint = "http://stg.en.data.api.observations.enqa.co/data/observations/v1/historical/ex"

    load_keyword = ["consumerUtilityId", "periodStartUnix", "periodEndUnix"]
    load_endpoint = "http://dr.api.earthnetworks.endev.co/demandresponse/report/powerdata/v1"

    @staticmethod
    def get_obs_data(providerid, stationid, startdatetimeutc, enddatetimeutc):
        """Make an obs api call, and return json data.
        
        :param providerid: int
        :param stationid: str
        :param startdatetimeutc: int/float timestamp or str or datetime
        :param enddatetimeutc: int/float timestamp or str or datetime
        """
        if not isinstance(startdatetimeutc, int):
            startdatetimeutc = round(
                rolex.to_utctimestamp(rolex.parse_datetime(startdatetimeutc)))
        if not isinstance(enddatetimeutc, int):
            enddatetimeutc = round(
                rolex.to_utctimestamp(rolex.parse_datetime(enddatetimeutc)))
        params = {
            "providerid": providerid,
            "stationid": stationid,
            "startdatetimeutc": startdatetimeutc,
            "enddatetimeutc": enddatetimeutc,
            "compact": True,
            "includeRsVersion": True,
        }
        response = requests.get(Spider.obs_endpoint, params=params)
        data = json.loads(response.text)
        return data

    @staticmethod
    def get_load_data(consumerUtilityId, periodStartUnix, periodEndUnix):
        if not isinstance(periodStartUnix, int):
            periodStartUnix = round(
                rolex.to_utctimestamp(rolex.parse_datetime(periodStartUnix)))
        if not isinstance(periodEndUnix, int):
            periodEndUnix = round(
                rolex.to_utctimestamp(rolex.parse_datetime(periodEndUnix)))
        params = {
            "consumerUtilityId": consumerUtilityId,
            "periodStartUnix": periodStartUnix,
            "periodEndUnix": periodEndUnix,
        }
        response = requests.get(Spider.load_endpoint, params=params)
        data = json.loads(response.text)
        return data

if __name__ == "__main__":
    from dataIO import js
    data = Spider.get_obs_data(
        3, "AWSHQ", "2016-05-01 00:00:00", "2016-05-01 00:59:59")
#     js.pprint(data)

    data = Spider.get_load_data(
        "10032789400168690", "2016-05-01 00:00:00", "2016-05-01 00:59:59")
#     js.pprint(data)
