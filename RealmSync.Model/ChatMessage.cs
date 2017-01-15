﻿using System;
using Newtonsoft.Json;
using RealmSync.SyncService;

namespace RealmSync.Model
{

    public partial class ChatMessage :
        Realms.RealmObject,
        IRealmSyncObjectClient
    {

        [Realms.PrimaryKey]
        public string Id { get; set; }

        public int SyncState { get; set; }

        [Realms.Ignored]
        public string MobilePrimaryKey => Id;

        [JsonIgnore]
        public string LastSynchronizedVersion { get; set; }
    }
}