/*  BACnetEngineeringUnits Enumeration
 *  Copyright (C) 2010 Loren Van Spronsen
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetEngineeringUnits
    {
        //Acceleration
        MetersPerSecondPerSecond = 166,

        //Area
        SquareMeters = 0,
        SquareCentimeters = 116,
        SquareFeet = 1,
        SquareInches = 115,

        //CurrencyCurrency1=105,
        Currency2 = 106,
        Currency3 = 107,
        Currency4 = 108,
        Currency5 = 109,
        Currency6 = 110,
        Currency7 = 111,
        Currency8 = 112,
        Currency9 = 113,
        Currency10 = 114,

        //Electrical
        Milliamperes = 2,
        Amperes = 3,
        AmperesPerMeter = 167,
        AmperesPerSquareMeter = 168,
        AmpereSquareMeters = 169,
        Farads = 170,
        Henrys = 171,
        Ohms = 4,
        OhmMeters = 172,
        Milliohms = 145,
        Kilohms = 122,
        Megohms = 123,
        Siemens = 173,
        //1MhoEquals1Siemens
        SiemensPerMeter = 174,
        Teslas = 175,
        Volts = 5,
        Millivolts = 124,
        Kilovolts = 6,
        Megavolts = 7,
        VoltAmperes = 8,
        KilovoltAmperes = 9,
        MegavoltAmperes = 10,
        VoltAmperesReactive = 11,
        KilovoltAmperesReactive = 12,
        MegavoltAmperesReactive = 13,
        VoltsPerDegreeKelvin = 176,
        VoltsPerMeter = 177,
        DegreesPhase = 14,
        PowerFactor = 15,
        Webers = 178,

        //Energy
        Joules = 16,
        Kilojoules = 17,
        KilojoulesPerKilogram = 125,
        Megajoules = 126,
        WattHours = 18,
        KilowattHours = 19,
        MegawattHours = 146,
        Btus = 20,
        KiloBtus = 147,
        MegaBtus = 148,
        Therms = 21,
        TonHours = 22,

        //Enthalpy
        JoulesPerKilogramDryAir = 23,
        KilojoulesPerKilogramDryAir = 149,
        MegajoulesPerKilogramDryAir = 150,
        BtusPerPoundDryAir = 24,
        BtusPerPound = 117,

        //Entropy
        JoulesPerDegreeKelvin = 127,
        KilojoulesPerDegreeKelvin = 151,
        MegajoulesPerDegreeKelvin = 152,
        JoulesPerKilogramDegreeKelvin = 128,

        //ForceNewton=153,

        //Frequency
        CyclesPerHour = 25,
        CyclesPerMinute = 26,
        Hertz = 27,
        Kilohertz = 129,
        Megahertz = 130,
        PerHour = 131,

        //Humidity
        GramsOfWaterPerKilogramDryAir = 28,
        PercentRelativeHumidity = 29,

        //Length
        Millimeters = 30,
        Centimeters = 118,
        Meters = 31,
        Inches = 32,
        Feet = 33,

        //Light
        Candelas = 179,
        CandelasPerSquareMeter = 180,
        WattsPerSquareFoot = 34,
        WattsPerSquareMeter = 35,
        Lumens = 36,
        Luxes = 37,
        FootCandles = 38,

        //Mass
        Kilograms = 39,
        PoundsMass = 40,
        Tons = 41,

        //MassFlow
        GramsPerSecond = 154,
        GramsPerMinute = 155,
        KilogramsPerSecond = 42,
        KilogramsPerMinute = 43,
        KilogramsPerHour = 44,
        PoundsMassPerSecond = 119,
        PoundsMassPerMinute = 45,
        PoundsMassPerHour = 46,
        TonsPerHour = 156,

        //Power
        Milliwatts = 132,
        Watts = 47,
        Kilowatts = 48,
        Megawatts = 49,
        BtusPerHour = 50,
        KiloBtusPerHour = 157,
        Horsepower = 51,
        TonsRefrigeration = 52,

        //Pressure
        Pascals = 53,
        Hectopascals = 133,
        Kilopascals = 54,
        Millibars = 134,
        Bars = 55,
        PoundsForcePerSquareInch = 56,
        CentimetersOfWater = 57,
        InchesOfWater = 58,
        MillimetersOfMercury = 59,
        CentimetersOfMercury = 60,
        InchesOfMercury = 61,

        //Temperature
        DegreesCelsius = 62,
        DegreesKelvin = 63,
        DegreesKelvinPerHour = 181,
        DegreesKelvinPerMinute = 182,
        DegreesFahrenheit = 64,
        DegreeDaysCelsius = 65,
        DegreeDaysFahrenheit = 66,
        DeltaDegreesFahrenheit = 120,
        DeltaDegreesKelvin = 121,

        //Time
        Years = 67,
        Months = 68,
        Weeks = 69,
        Days = 70,
        Hours = 71,
        Minutes = 72,
        Seconds = 73,
        HundredthsSeconds = 158,
        Milliseconds = 159,

        //Torque
        NewtonMeters = 160,

        //Velocity
        MillimetersPerSecond = 161,
        MillimetersPerMinute = 162,
        MetersPerSecond = 74,
        MetersPerMinute = 163,
        MetersPerHour = 164,
        KilometersPerHour = 75,
        FeetPerSecond = 76,
        FeetPerMinute = 77,
        MilesPerHour = 78,

        //Volume
        CubicFeet = 79,
        CubicMeters = 80,
        ImperialGallons = 81,
        Liters = 82,
        UsGallons = 83,

        //VolumetricFlow
        CubicFeetPerSecond = 142,
        CubicFeetPerMinute = 84,
        CubicMetersPerSecond = 85,
        CubicMetersPerMinute = 165,
        CubicMetersPerHour = 135,
        ImperialGallonsPerMinute = 86,
        LitersPerSecond = 87,
        LitersPerMinute = 88,
        LitersPerHour = 136,
        UsGallonsPerMinute = 89,

        //Other
        DegreesAngular = 90,
        DegreesCelsiusPerHour = 91,
        DegreesCelsiusPerMinute = 92,
        DegreesFahrenheitPerHour = 93,
        DegreesFahrenheitPerMinute = 94,
        JouleSeconds = 183,
        KilogramsPerCubicMeter = 186,
        KilowattHoursPerSquareMeter = 137,
        KilowattHoursPerSquareFoot = 138,
        MegajoulesPerSquareMeter = 139,
        MegajoulesPerSquareFoot = 140,
        NoUnits = 95,
        NewtonSeconds = 187,
        NewtonsPerMeter = 188,
        PartsPerMillion = 96,
        PartsPerBillion = 97,
        Percent = 98,
        PercentObscurationPerFoot = 143,
        PercentObscurationPerMeter = 144,
        PercentPerSecond = 99,
        PerMinute = 100,
        PerSecond = 101,
        PsiPerDegreeFahrenheit = 102,
        Radians = 103,
        RadiansPerSecond = 184,
        RevolutionsPerMinute = 104,
        SquareMetersPerNewton = 185,
        WattsPerMeterPerDegreeKelvin = 189,
        WattsPerSquareMeterDegreeKelvin = 141
    }
}
