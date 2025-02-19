﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidCrawler.Structures
{
    public static class SpeciesConverter
    {
        public static ushort FromEncounterToDex(ushort encounterNumber)
        {
            return encounterNumber switch
            {
                906 => 906,
                907 => 907,
                908 => 908,
                909 => 909,
                910 => 910,
                911 => 911,
                912 => 912,
                913 => 913,
                914 => 914,
                915 => 915,
                916 => 916,
                918 => 917,
                919 => 918,
                920 => 919,
                921 => 920,
                954 => 921,
                955 => 922,
                956 => 923,
                945 => 924,
                946 => 925,
                970 => 926,
                971 => 927,
                935 => 928,
                936 => 929,
                937 => 930,
                960 => 931,
                963 => 932,
                964 => 933,
                965 => 934,
                1003 => 935,
                1004 => 936,
                1005 => 937,
                940 => 938,
                941 => 939,
                957 => 940,
                958 => 941,
                972 => 942,
                973 => 943,
                968 => 944,
                969 => 945,
                974 => 946,
                975 => 947,
                1006 => 948,
                1007 => 949,
                962 => 950,
                938 => 951,
                939 => 952,
                922 => 953,
                923 => 954,
                926 => 955,
                927 => 956,
                1000 => 957,
                1001 => 958,
                1002 => 959,
                929 => 960,
                930 => 961,
                959 => 962,
                933 => 963,
                934 => 964,
                942 => 965,
                943 => 966,
                953 => 967,
                944 => 968,
                966 => 969,
                967 => 970,
                924 => 971,
                925 => 972,
                961 => 973,
                947 => 974,
                948 => 975,
                932 => 976,
                931 => 977,
                952 => 978,
                1010 => 979,
                1009 => 980,
                928 => 981,
                917 => 982,
                1008 => 983,
                978 => 984,
                982 => 985,
                979 => 986,
                983 => 987,
                984 => 988,
                981 => 989,
                986 => 990,
                992 => 991,
                989 => 992,
                990 => 993,
                988 => 994,
                991 => 995,
                949 => 996,
                950 => 997,
                951 => 998,
                976 => 999,
                977 => 1000,
                996 => 1001,
                995 => 1002,
                994 => 1003,
                997 => 1004,
                985 => 1005,
                993 => 1006,
                998 => 1007,
                999 => 1008,
                _ => encounterNumber
            };
        }
        public static ushort FromDexToEncounter(ushort dexNumber)
        {
            return dexNumber switch
            {
                906 => 906,
                907 => 907,
                908 => 908,
                909 => 909,
                910 => 910,
                911 => 911,
                912 => 912,
                913 => 913,
                914 => 914,
                915 => 915,
                916 => 916,
                917 => 918,
                918 => 919,
                919 => 920,
                920 => 921,
                921 => 954,
                922 => 955,
                923 => 956,
                924 => 945,
                925 => 946,
                926 => 970,
                927 => 971,
                928 => 935,
                929 => 936,
                930 => 937,
                931 => 960,
                932 => 963,
                933 => 964,
                934 => 965,
                935 => 1003,
                936 => 1004,
                937 => 1005,
                938 => 940,
                939 => 941,
                940 => 957,
                941 => 958,
                942 => 972,
                943 => 973,
                944 => 968,
                945 => 969,
                946 => 974,
                947 => 975,
                948 => 1006,
                949 => 1007,
                950 => 962,
                951 => 938,
                952 => 939,
                953 => 922,
                954 => 923,
                955 => 926,
                956 => 927,
                957 => 1000,
                958 => 1001,
                959 => 1002,
                960 => 929,
                961 => 930,
                962 => 959,
                963 => 933,
                964 => 934,
                965 => 942,
                966 => 943,
                967 => 953,
                968 => 944,
                969 => 966,
                970 => 967,
                971 => 924,
                972 => 925,
                973 => 961,
                974 => 947,
                975 => 948,
                976 => 932,
                977 => 931,
                978 => 952,
                979 => 1010,
                980 => 1009,
                981 => 928,
                982 => 917,
                983 => 1008,
                984 => 978,
                985 => 982,
                986 => 979,
                987 => 983,
                988 => 984,
                989 => 981,
                990 => 986,
                991 => 992,
                992 => 989,
                993 => 990,
                994 => 988,
                995 => 991,
                996 => 949,
                997 => 950,
                998 => 951,
                999 => 976,
                1000 => 977,
                1001 => 996,
                1002 => 995,
                1003 => 994,
                1004 => 997,
                1005 => 985,
                1006 => 993,
                1007 => 998,
                1008 => 999,
                // anything before gen9 is fine
                _ => dexNumber,
            };
        }
    }
}
