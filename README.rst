.. image:: https://img.shields.io/badge/Author-Sanhe_Hu-01DF3A.svg

.. image:: https://img.shields.io/badge/License-All_Rights_Reserved-FA5858.svg

.. image:: https://img.shields.io/badge/Python-Py2_Py3-58ACFA.svg


Welcome to wbhapi Documentation
===============================================================================
``wbhapi`` is a objective-oriented library for weatherbug observation data API.

Example:

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

	# Do what ever you want ...
	df.to_csv("data.csv", index=False)


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