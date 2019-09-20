﻿using Bootstrap.DataAccess;

namespace Bootstrap.Admin.Models
{
    /// <summary>
    /// ModelBase 基础类
    /// </summary>
    public class ModelBase
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ModelBase()
        {
            Title = DictHelper.RetrieveWebTitle();
            Footer = DictHelper.RetrieveWebFooter();
            Theme = DictHelper.RetrieveActiveTheme();
            IsDemo = DictHelper.RetrieveSystemModel();
            ShowCardTitle = DictHelper.RetrieveCardTitleStatus() ? "" : "no-card-header";
            ShowSideBar = DictHelper.RetrieveSidebarStatus() ? "" : "collapsed";
            AllowMobile = DictHelper.RetrieveMobileLogin();
            AllowOAuth = DictHelper.RetrieveOAuthLogin();
            ShowMobile = AllowMobile ? "" : "mobile";
            ShowOAuth = AllowOAuth ? "" : "oauth";
        }

        /// <summary>
        /// 获取 网站标题
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// 获取 网站页脚
        /// </summary>
        public string Footer { get; private set; }

        /// <summary>
        /// 网站样式全局设置
        /// </summary>
        public string Theme { get; protected set; }

        /// <summary>
        /// 是否为演示系统
        /// </summary>
        public bool IsDemo { get; protected set; }

        /// <summary>
        /// 是否显示卡片标题
        /// </summary>
        public string ShowCardTitle { get; protected set; }

        /// <summary>
        /// 是否收缩侧边栏
        /// </summary>
        public string ShowSideBar { get; protected set; }

        /// <summary>
        /// 获得 是否允许短信验证码登录
        /// </summary>
        public bool AllowMobile { get; }

        /// <summary>
        /// 获得 是否允许第三方 OAuth 认证登录
        /// </summary>
        public bool AllowOAuth { get; }

        /// <summary>
        /// 获得 是否允许短信验证码登录
        /// </summary>
        public string ShowMobile { get; }

        /// <summary>
        /// 获得 是否允许第三方 OAuth 认证登录
        /// </summary>
        public string ShowOAuth { get; }
    }
}
