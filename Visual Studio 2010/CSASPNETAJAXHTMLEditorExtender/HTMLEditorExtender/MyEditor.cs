﻿/********************************** 模块头 ***********************************\
* 模块名:        MyEditor.cs
* 项目名:        CSASPNETHTMLEditorExtender
* 版权(c) Microsoft Corporation
*
* 这个类作出新的Editor控件来保存我们创建工具栏按钮.
* 
* Ajax控件工具包包含一套可以供您使用建立高度敏感和交互式AJAX的ASP.NET Web窗体
* 应用的丰富控件.我们可以从此链接开始学习和下载AjaxControlkit:
* http://www.asp.net/ajaxlibrary/act.ashx
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
*
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*****************************************************************************/


using System;
using AjaxControlToolkit.HTMLEditor;
using HTMLEditorExtender.ToolBar_buttons;

namespace HTMLEditorExtender
{
    public class MyEditor : Editor
    {
        protected override void FillTopToolbar()
        {
            base.FillTopToolbar();
            TopToolbar.Buttons.Add(new H1());
        }
    }
}
