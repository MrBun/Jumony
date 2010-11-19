﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html
{
  public interface IHtmlDocument : IHtmlNodeContainer
  {
    /// <summary>
    /// 获取文档的声明信息，可以是xml声明，也可以是DTD。如果不被支持，则返回null。
    /// </summary>
    string DocumentDeclaration
    {
      get;
    }


    /// <summary>
    /// 获取文档节点构造器，如果不支持，则返回null
    /// </summary>
    /// <returns>文档节点构造器</returns>
    IHtmlNodeFactory GetNodeFactory();


  }
}
