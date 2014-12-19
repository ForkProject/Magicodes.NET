﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Magicodes.Web.Interfaces.Plus;
using Magicodes.Web.Interfaces;
using Magicodes.Web.Interfaces.DocumentProtocols;
//======================================================================
//
//        Copyright (C) 2014-2016 Magicodes.NET团队    
//        All rights reserved
//
//        filename :Plus
//        description :
//
//        created by 雪雁 at  2014/12/18 14:26:29
//        http://www.magicodes.net
//
//======================================================================
namespace Magicodes.PDFViewer
{
    public class Plus : IPlus
    {
        public void Initialize()
        {
            var protocols = GlobalApplicationObject.Current.ApplicationContext.DocumentsOpenProtocolManager.DocumentOpenProtocols;
            if (!protocols.Any(p => p.ContentType.Equals("application/pdf", StringComparison.CurrentCultureIgnoreCase)))
            {
                protocols.Add(new DocumentOpenProtocol()
                {
                    ContentType = "application/pdf",
                    ViewerUrl = "/plus/Plugins/Magicodes.PDFViewer/Views/PDFViewer/Index.cshtml"
                });
            }
        }

        public void Install()
        {

        }

        public void Uninstall()
        {

        }
    }
}