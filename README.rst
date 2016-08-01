.. image:: https://img.shields.io/badge/Author-Sanhe_Hu-01DF3A.svg

.. image:: https://img.shields.io/badge/License-All_Rights_Reserved-FA5858.svg

.. image:: https://img.shields.io/badge/Python-Py2_Py3-58ACFA.svg


Welcome to wbhapi Documentation
===============================================================================
``wbhapi`` is a library for weatherbug observation data API.

This is the ordinary way of making data call:

1. visit endpoint: http://stg.en.data.api.observations.enqa.co/data/observations/v1/historical/ex?startdatetimeutc=1462060800&includeRsVersion=True&providerid=3&enddatetimeutc=1462064399&stationid=AWSHQ&compact=True
2. parse json, get understand about the data structure.
3. take useful information out.

This is the new Style!

.. code-block:: python

	import pandas as pd
	from wbhapi import spider, model

	# Naive dict data
	data = spider.Spider.get_obs_data(3, "AWSHQ", "2016-05-01 00:00:00", "2016-05-01 00:59:59")

	# Objective data
	en_historical_obs = model.Loader.load_en_historical_obs(data)

	# Export to tabulate style
	table = en_historical_obs.get_core_data()

	# Convert to DataFrame
	df = pd.DataFrame(en_historical_obs)

	...         observation_time_utc  temperatureC
	... 0  2016-05-01 00:00:02+00:00     11.216449
	... 1  2016-05-01 00:05:00+00:00     11.375708
	... 2  2016-05-01 00:10:00+00:00     11.342919
	... 3  2016-05-01 00:14:58+00:00     11.310131
	... 4  2016-05-01 00:20:01+00:00     11.216449
	... 5  2016-05-01 00:25:01+00:00     11.249237
	... 6  2016-05-01 00:30:00+00:00     11.183660
	... 7  2016-05-01 00:35:01+00:00     11.249237
	... 8  2016-05-01 00:40:01+00:00     11.155556
	... 9  2016-05-01 00:45:00+00:00     11.122767
	... 10 2016-05-01 00:48:04+00:00     11.089978
	... 11 2016-05-01 00:55:01+00:00     11.029085

	# Do what ever you want ...
	df.to_csv("data.csv", index=False)

Easy to use objective-oriented style field visiting:

.. code-block:: python

	>>> en_historical_obs.result.station
	EnStation(
	    provider_id=3, provider_name='Earth Networks Inc', station_id='AWSHQ', 
	    station_name='WeatherBug Headquarters', latitude=39.2005555555556, 
	    longitude=-77.2630555555556, display_flag=0, 
	    elevation_above_sea_level_meters=162.0, time_zone='America/New_York', 
	    inactive=False,
	)

	>>> for historical_observation in en_historical_obs.result.historical_observation:
	...     print(historical_observation.observation)

	... EnObservation(observation_time_utc=datetime.datetime(2016, 5, 1, 0, 0, 2, tzinfo=tzutc()), 
	    temperatureC=TemperatureC(value=11.2164488017429))
	... EnObservation(observation_time_utc=datetime.datetime(2016, 5, 1, 0, 5, tzinfo=tzutc()), 
	    temperatureC=TemperatureC(value=11.3757080610022))
	... EnObservation(observation_time_utc=datetime.datetime(2016, 5, 1, 0, 10, tzinfo=tzutc()), 
	    temperatureC=TemperatureC(value=11.3429193899782))


.. _install:

Install
-------------------------------------------------------------------------------

First, you need to `download source code <https://github.com/WeatherBugSandbox/wbhapi-project>`_ and extract. Then:

.. code-block:: console

	$ cd <path-to-the-directory-having-setup.py-file>
	$ pip install .

To upgrade to latest version:

.. code-block:: console

	$ pip install --upgrade .