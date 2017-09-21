using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Unidal.Cat
{
    public class CatConstants
    {
        public const String SUCCESS = "0";
        public const String UNKNOWN_DOMAIN = "Unknown";
        public const String LOCAL_CLIENT_CONFIG = "LocalClientConfig";
        public const String NULL_STRING = "null";

        /**
         * CAT client internal constants
         */
        public const String CAT_CONTEXT = "CatContext";
        public const String ID_MARK_FILE_MAP = "CatMarkFileMap";
        public const int ID_MARK_FILE_SIZE = 20;
        public const int ID_MARK_FILE_INDEX_OFFSET = 0;
        public const int ID_MARK_FILE_TS_OFFSET = 4;
        public const int ID_MARK_FILE_FLUSH_RATE = 1000;

        public const int HEARTBEAT_MIN_INITIAL_SLEEP_MILLISECONDS = 10000;
        public const int HEARTBEAT_MAX_INITIAL_SLEEP_MILLISECONDS = 60000;

        public const string DUMP_LOCKED = "dumpLocked";

        public const int TAGGED_TRANSACTION_CACHE_SIZE = 1024;

        // Prod
        public const int REFRESH_ROUTER_CONFIG_INTERVAL = 3600 * 1000;
        public const int TCP_RECONNECT_INTERVAL = 300 * 1000;
        public const int TCP_REBALANCE_INTERVAL = 600 * 1000;
        public const int TCP_CHECK_INTERVAL = 60000;

        public const string CAT_FILE_DIR = @"D:\data\appdatas\cat";

        /**
         * Remote call context info 
         */
        public const String ROOT_MESSAGE_ID = "RootMessageId";
        public const String CURRENT_MESSAGE_ID = "CurrentMessageId";
        public const String SERVER_MESSAGE_ID = "ServerMessageId";
        public const String CALL_APP = "CallApp";
        public const String TYPE_REMOTE_CALL = "RemoteCall";
        public const String NAME_REQUEST = "CallRequest";

        /**
         * LogEnable
         */
        public const String LOG_ENABLE = "LogEnabled";
        public const String CAT_HOME = @"D:\data\applogs";
        public const String CAT_HOME_TEMP = @"D:\data\applogs\cat";

        /**
         *  DurationRang
         */
        public static List<KeyValuePair<long, String>> DURATION_LIST = new List<KeyValuePair<long, String>> 
        {
            new KeyValuePair<long, String>(10,"0~10ms"),
            new KeyValuePair<long, String>(50,"10~50ms"),
            new KeyValuePair<long, String>(100,"50~100ms"),
            new KeyValuePair<long, String>(200,"100~200ms"),
            new KeyValuePair<long, String>(500,"200~500ms"),
            new KeyValuePair<long, String>(1000,"500ms~1s"),
            new KeyValuePair<long, String>(5000,"1~5s"),
            new KeyValuePair<long, String>(10000,"5~10s"),
            new KeyValuePair<long, String>(20000,"10~20s"),
            new KeyValuePair<long, String>(30000,"20~30s"),
            new KeyValuePair<long, String>(50000,"30~50s"),
            new KeyValuePair<long, String>(120000,"50~120s"),
            new KeyValuePair<long, String>(300000,"2~5m"),
            new KeyValuePair<long, String>(600000,"5~10m"),
        };
    }
}
