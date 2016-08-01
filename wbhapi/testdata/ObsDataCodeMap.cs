using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EarthNetworks.EcoConnect.Data.EnHistorical
{
    [DataContract(Name = "S")]
    public class EnStation
    {
        [DataMember(Name = "pid")]
        public int ProviderId { get; set; }
        [DataMember(Name = "pn")]
        public string ProviderName { get; set; }
        [DataMember(Name = "sid")]
        public string StationId { get; set; }
        [DataMember(Name = "sn")]
        public string StationName { get; set; }
        [DataMember(Name = "lat")]
        public double? Latitude { get; set; }
        [DataMember(Name = "lon")]
        public double? Longitude { get; set; }
        [DataMember(Name = "df")]
        public object DisplayFlag { get; set; }
        [DataMember(Name = "el")]
        public double? ElevationAboveSeaLevelMeters { get; set; }
        [DataMember(Name = "tz")]
        public string TimeZone { get; set; }
        [DataMember(Name = "i")]
        public bool Inactive { get; set; }
    }

    [DataContract(Name = "Ath")]
    public class AuxTemperatureHighC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Atl")]
    public class AuxTemperatureLowC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Hh")]
    public class HumidityHigh
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Hl2")]
    public class HumidityLow
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Ith")]
    public class IndoorTemperatureHighC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Itl")]
    public class IndoorTemperatureLowC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Lh")]
    public class LightHigh
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Ll")]
    public class LightLow
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Pslh")]
    public class PressureSeaLevelHighMBar
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Psll")]
    public class PressureSeaLevelLowMBar
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Rrm")]
    public class RainRateMaxMmPerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Th")]
    public class TemperatureHighC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Tl")]
    public class TemperatureLowC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Hl")]
    public class HighLow
    {
        [DataMember(Name = "ath")]
        public AuxTemperatureHighC AuxTemperatureHighC { get; set; }
        [DataMember(Name = "athu")]
        public string AuxTemperatureHighUtc { get; set; }
        [DataMember(Name = "atl")]
        public AuxTemperatureLowC AuxTemperatureLowC { get; set; }
        [DataMember(Name = "atlu")]
        public string AuxTemperatureLowUtc { get; set; }
        [DataMember(Name = "hh")]
        public HumidityHigh HumidityHigh { get; set; }
        [DataMember(Name = "hhu")]
        public string HumidityHighUtc { get; set; }
        [DataMember(Name = "hl")]
        public HumidityLow HumidityLow { get; set; }
        [DataMember(Name = "hlu")]
        public string HumidityLowUtc { get; set; }
        [DataMember(Name = "ith")]
        public IndoorTemperatureHighC IndoorTemperatureHighC { get; set; }
        [DataMember(Name = "ithu")]
        public string IndoorTemperatureHighUtc { get; set; }
        [DataMember(Name = "itl")]
        public IndoorTemperatureLowC IndoorTemperatureLowC { get; set; }
        [DataMember(Name = "itlu")]
        public string IndoorTemperatureLowUtc { get; set; }
        [DataMember(Name = "lh")]
        public LightHigh LightHigh { get; set; }
        [DataMember(Name = "lhu")]
        public string LightHighUtc { get; set; }
        [DataMember(Name = "ll")]
        public LightLow LightLow { get; set; }
        [DataMember(Name = "llu")]
        public string LightLowUtc { get; set; }
        [DataMember(Name = "pslh")]
        public PressureSeaLevelHighMBar PressureSeaLevelHighMBar { get; set; }
        [DataMember(Name = "pslhu")]
        public string PressureSeaLevelHighUtc { get; set; }
        [DataMember(Name = "psll")]
        public PressureSeaLevelLowMBar PressureSeaLevelLowMBar { get; set; }
        [DataMember(Name = "psllu")]
        public string PressureSeaLevelLowUtc { get; set; }
        [DataMember(Name = "rrm")]
        public RainRateMaxMmPerHour RainRateMaxMmPerHour { get; set; }
        [DataMember(Name = "rrmu")]
        public string RainRateMaxUtc { get; set; }
        [DataMember(Name = "th")]
        public TemperatureHighC TemperatureHighC { get; set; }
        [DataMember(Name = "thu")]
        public string TemperatureHighUtc { get; set; }
        [DataMember(Name = "tl")]
        public TemperatureLowC TemperatureLowC { get; set; }
        [DataMember(Name = "tlu")]
        public string TemperatureLowUtc { get; set; }
    }

    [DataContract(Name = "A")]
    public class AltimeterMBar
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Ar")]
    public class AltimeterMBarRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Dp")]
    public class DewPointC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Dpr")]
    public class DewPointCRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Hi")]
    public class HeatIndexC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "H")]
    public class Humidity
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Hr")]
    public class HumidityRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "L")]
    public class Light
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Lr")]
    public class LightRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Psl")]
    public class PressureSeaLevelMBar
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Pslr")]
    public class PressureSeaLevelMBarRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Pstl")]
    public class PressureStationLevelMBar
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Pstlr")]
    public class PressureStationLevelMBarRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Rd")]
    public class RainMillimetersDaily
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Rr")]
    public class RainMillimetersRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Rm")]
    public class RainMillimetersMonthly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Ry")]
    public class RainMillimetersYearly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Sd")]
    public class SnowMillimetersDaily
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Sr")]
    public class SnowMillimetersRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Sm")]
    public class SnowMillimetersMonthly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Sy")]
    public class SnowMillimetersYearly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "T")]
    public class TemperatureC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Tr")]
    public class TemperatureCRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "V")]
    public class VisibilityKilometers
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Vr")]
    public class VisibilityKilometersRatePerHour
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wc")]
    public class WindChillC
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Ws")]
    public class WindSpeedKph
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wd")]
    public class WindDirectionDegrees
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wsa")]
    public class WindSpeedKphAvg
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wda")]
    public class WindDirectionDegreesAvg
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wga")]
    public class WindGustKphHourly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wgdh")]
    public class WindGustDirectionDegreesHourly
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wgd")]
    public class WindGustKphDaily
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "Wgdd")]
    public class WindGustDirectionDegreesDaily
    {
        [DataMember(Name = "v")]
        public double? Value { get; set; }
        [DataMember(Name = "q")]
        public string QcDataDescriptor { get; set; }
    }

    [DataContract(Name = "O")]
    public class EnObservation
    {
        [DataMember(Name = "k")]
        public string Key { get; set; }
        [DataMember(Name = "si")]
        public string StationId { get; set; }
        [DataMember(Name = "pi")]
        public int? ProviderId { get; set; }
        [DataMember(Name = "otu")]
        public string ObservationTimeUtc { get; set; }
        [DataMember(Name = "otus")]
        public string ObservationTimeUtcStr { get; set; }
        [DataMember(Name = "ic")]
        public int? IconCode { get; set; }
        [DataMember(Name = "a")]
        public AltimeterMBar AltimeterMBar { get; set; }
        [DataMember(Name = "ar")]
        public AltimeterMBarRatePerHour AltimeterMBarRatePerHour { get; set; }
        [DataMember(Name = "at")]
        public double? AuxTemperatureC { get; set; }
        [DataMember(Name = "atr")]
        public double? AuxTemperatureCRatePerHour { get; set; }
        [DataMember(Name = "dp")]
        public DewPointC DewPointC { get; set; }
        [DataMember(Name = "dpr")]
        public DewPointCRatePerHour DewPointCRatePerHour { get; set; }
        [DataMember(Name = "hi")]
        public HeatIndexC HeatIndexC { get; set; }
        [DataMember(Name = "h")]
        public Humidity Humidity { get; set; }
        [DataMember(Name = "hr")]
        public HumidityRatePerHour HumidityRatePerHour { get; set; }
        [DataMember(Name = "it")]
        public double? IndoorTemperatureC { get; set; }
        [DataMember(Name = "itr")]
        public double? IndoorTemperatureCRatePerHour { get; set; }
        [DataMember(Name = "l")]
        public Light Light { get; set; }
        [DataMember(Name = "lr")]
        public LightRatePerHour LightRatePerHour { get; set; }
        [DataMember(Name = "psl")]
        public PressureSeaLevelMBar PressureSeaLevelMBar { get; set; }
        [DataMember(Name = "pslr")]
        public PressureSeaLevelMBarRatePerHour PressureSeaLevelMBarRatePerHour { get; set; }
        [DataMember(Name = "pstl")]
        public PressureStationLevelMBar PressureStationLevelMBar { get; set; }
        [DataMember(Name = "pstlr")]
        public PressureStationLevelMBarRatePerHour PressureStationLevelMBarRatePerHour { get; set; }
        [DataMember(Name = "rd")]
        public RainMillimetersDaily RainMillimetersDaily { get; set; }
        [DataMember(Name = "rr")]
        public RainMillimetersRatePerHour RainMillimetersRatePerHour { get; set; }
        [DataMember(Name = "rm")]
        public RainMillimetersMonthly RainMillimetersMonthly { get; set; }
        [DataMember(Name = "ry")]
        public RainMillimetersYearly RainMillimetersYearly { get; set; }
        [DataMember(Name = "sd")]
        public SnowMillimetersDaily SnowMillimetersDaily { get; set; }
        [DataMember(Name = "sr")]
        public SnowMillimetersRatePerHour SnowMillimetersRatePerHour { get; set; }
        [DataMember(Name = "sm")]
        public SnowMillimetersMonthly SnowMillimetersMonthly { get; set; }
        [DataMember(Name = "sy")]
        public SnowMillimetersYearly SnowMillimetersYearly { get; set; }
        [DataMember(Name = "t")]
        public TemperatureC TemperatureC { get; set; }
        [DataMember(Name = "tr")]
        public TemperatureCRatePerHour TemperatureCRatePerHour { get; set; }
        [DataMember(Name = "v")]
        public VisibilityKilometers VisibilityKilometers { get; set; }
        [DataMember(Name = "vr")]
        public VisibilityKilometersRatePerHour VisibilityKilometersRatePerHour { get; set; }
        [DataMember(Name = "wc")]
        public WindChillC WindChillC { get; set; }
        [DataMember(Name = "ws")]
        public WindSpeedKph WindSpeedKph { get; set; }
        [DataMember(Name = "wd")]
        public WindDirectionDegrees WindDirectionDegrees { get; set; }
        [DataMember(Name = "wsa")]
        public WindSpeedKphAvg WindSpeedKphAvg { get; set; }
        [DataMember(Name = "wda")]
        public WindDirectionDegreesAvg WindDirectionDegreesAvg { get; set; }
        [DataMember(Name = "wgh")]
        public WindGustKphHourly WindGustKphHourly { get; set; }
        [DataMember(Name = "wgtuh")]
        public string WindGustTimeUtcHourly { get; set; }
        [DataMember(Name = "wgtuhs")]
        public string WindGustTimeUtcHourlyStr { get; set; }
        [DataMember(Name = "wgdh")]
        public WindGustDirectionDegreesHourly WindGustDirectionDegreesHourly { get; set; }
        [DataMember(Name = "wgd")]
        public WindGustKphDaily WindGustKphDaily { get; set; }
        [DataMember(Name = "wgtud")]
        public string WindGustTimeUtcDaily { get; set; }
        [DataMember(Name = "wgtuds")]
        public string WindGustTimeUtcDailyStr { get; set; }
        [DataMember(Name = "wgdd")]
        public WindGustDirectionDegreesDaily WindGustDirectionDegreesDaily { get; set; }
    }

    [DataContract(Name = "Eo")]
    public class ExtendedOb
    {
        [DataMember(Name = "k")]
        public string Key { get; set; }
        [DataMember(Name = "v")]
        public string Value { get; set; }
    }

    [DataContract(Name = "Ho")]
    public class HistoricalObservation
    {
        [DataMember(Name = "hl")]
        public HighLow HighLow { get; set; }
        [DataMember(Name = "o")]
        public EnObservation Observation { get; set; }
        [DataMember(Name = "eo")]
        public List<ExtendedOb> ExtendedObs { get; set; }
    }

    [DataContract(Name = "R")]
    public class Result
    {
        [DataMember(Name = "s")]
        public EnStation Station { get; set; }
        [DataMember(Name = "ho")]
        public List<HistoricalObservation> HistoricalObservations { get; set; }
    }

    [DataContract]
    public class EnHistoricalObs
    {
        [DataMember(Name = "r")]
        public Result Result { get; set; }
        [DataMember(Name = "c")]
        public int? Code { get; set; }
        [DataMember(Name = "e")]
        public object ErrorMessage { get; set; }
        [DataMember(Name = "i")]
        public string Id { get; set; }
    }
}
