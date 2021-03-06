﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgilePrinciplesPractice.Ch35.Visitor
{
    public class UnixModemConfigurator : ModemVisitor
    {
        public void Visit(HayesModem m)
        {
            m.configurationString = "&s1=4&D3";
        }

        public void Visit(ZoomModem m)
        {
            m.configurationValue = 42;
        }

        public void Visit(ErnieModem m)
        {
            m.internalPattern = "c is too slow";
        }
    }
}