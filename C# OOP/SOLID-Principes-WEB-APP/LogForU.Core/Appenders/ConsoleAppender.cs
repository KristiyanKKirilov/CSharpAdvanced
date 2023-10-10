﻿using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Layouts.Interfaces;
using LogForU.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }
        public ILayout Layout  { get; private set;}

        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }


        public void AppendMessage(Message message)
        {
            string content = string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text);
            Console.WriteLine(content);
            MessagesAppended++;
        }
    }
}