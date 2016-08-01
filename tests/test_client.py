#!/usr/bin/env python
# -*- coding: utf-8 -*-

import pandas as pd
from wbhapi import spider, model

data = spider.Spider.get_obs_data(3, "AWSHQ", "2016-05-01 00:00:00", "2016-05-01 00:59:59")
en_historical_obs = model.Loader.load_en_historical_obs(data)

# print(en_historical_obs)
# print(en_historical_obs.result)
# print(en_historical_obs.result.station)
# for historical_observation in en_historical_obs.result.historical_observation:
#     print(historical_observation)
# print(en_historical_obs.result.historical_observation[0].observation)
# print(en_historical_obs.result.historical_observation[0].observation.temperatureC)
# df = pd.DataFrame(en_historical_obs.get_core_data())
# print(df)


data = spider.Spider.get_load_data("10032789400168690", "2016-05-01 00:00:00", "2016-05-01 00:59:59")
load_obs = model.Loader.load_load_obs(data)

# print(load_obs)
# print(load_obs.result)
# for record in load_obs.result.records:
#     print(record)
# df = pd.DataFrame(load_obs.get_core_data())
# print(df)