﻿using System;

namespace NewLife.RocketMQ.Protocol
{
    /// <summary>发送结果</summary>
    public class SendResult
    {
        #region 属性
        public SendStatus Status { get; set; }

        public String MsgId { get; set; }

        public MessageQueue Queue { get; set; }

        public Int64 QueueOffset { get; set; }

        public String TransactionId { get; set; }

        public String OffsetMsgId { get; set; }

        public String RegionId { get; set; }
        #endregion
    }
}