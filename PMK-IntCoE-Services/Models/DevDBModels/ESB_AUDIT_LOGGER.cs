using PMK_IntCoE_Services.Data.DevDBData;
using System;
using System.Collections.Generic;

namespace PMK_IntCoE_Services.Models.DevDBModels
{
    public partial class ESB_AUDIT_LOGGER
    {
        public string ROWID { get; set; }
        public string MESSAGETYPE { get; set; }
        public DateTime AUDIT_TIMESTAMP { get; set; }
        public string GLOBALTRANSACTIONID { get; set; }
        public string LOCALTRANSACTIONID { get; set; }
        public string PARENTTRANSACTIONID { get; set; }
        public string PROJECTNAME { get; set; }
        public string INTERFACE_ID { get; set; }
        public string INTERFACENAME { get; set; }
        public string SOURCEAPP { get; set; }
        public string DESTINATIONAPP { get; set; }
        public string AUDITTYPE { get; set; }
        public string TOOLNAME { get; set; }
        public string BROKERNAME { get; set; }
        public string BROKERFAMILY { get; set; }
        public string EXECUTIONGROUP { get; set; }
        public string QUEUEMANAGER { get; set; }
        public string INPUTQUEUE { get; set; }
        public string MSGFLOW { get; set; }
        public string KEYIDENTIFIER { get; set; }
        public string ORIGINALMESSAGE { get; set; }
        public string MESSAGEDETAILS { get; set; }
        public string MISCELLANEOUS { get; set; }
        public string MESSAGEID { get; set; }
        public DateTime? INSERT_TIMESTAMP { get; set; }

        //public override string ToString() => DBser
    }
}
