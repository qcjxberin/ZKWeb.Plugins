﻿using DryIoc;
using DryIocAttributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZKWeb;
using ZKWeb.Core;
using ZKWeb.Model;
using ZKWeb.Model.ActionResults;
using ZKWeb.Plugins.Common.Admin.src.Forms;
using ZKWeb.Plugins.Common.Base.src.Database;

namespace ZKWeb.Plugins.Common.Base.src.Controllers {
	/// <summary>
	/// 后台的控制器
	/// </summary>
	[ExportMany]
	public class AdminController : IController {
		/// <summary>
		/// 后台首页
		/// </summary>
		/// <returns></returns>
		[Action("admin")]
		public IActionResult Admin() {
			return new TemplateResult("common.admin.admin.html");
		}

		/// <summary>
		/// 后台登陆页
		/// </summary>
		/// <returns></returns>
		[Action("admin/login")]
		[Action("admin/login", HttpMethods.POST)]
		public IActionResult Login() {
			var form = new AdminLoginForm();
			var request = HttpContext.Current.Request;
			if (request.HttpMethod == HttpMethods.POST) {
				return new JsonResult(form.Submit());
			} else {
				form.Bind();
				return new TemplateResult("common.admin.login.html", new { form });
			}
		}

		/// <summary>
		/// 退出后台登陆
		/// </summary>
		/// <returns></returns>
		[Action("admin/logout")]
		public IActionResult Logout() {
			throw new NotImplementedException();
		}
	}
}