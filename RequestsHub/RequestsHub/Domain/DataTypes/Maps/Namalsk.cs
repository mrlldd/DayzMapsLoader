﻿using RequestsHub.Domain.Contracts;

namespace RequestsHub.Domain.DataTypes.Maps
{
    internal class Namalsk : IMap
    {
        public Namalsk(Dictionary<int, MapSize> keyValuePairsSize, List<TypeMap> typesMap, string version)
        {
            KeyValuePairsSize = keyValuePairsSize;
            TypesMap = typesMap;
            Version = version;
        }

        public Namalsk()
        {
        }

        public Dictionary<int, MapSize> KeyValuePairsSize { get; set; }
        public NameMap Name => NameMap.namalsk;
        public List<TypeMap> TypesMap { get; set; }
        public string Version { get; set; }
    }
}