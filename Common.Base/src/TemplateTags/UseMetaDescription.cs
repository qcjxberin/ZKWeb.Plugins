﻿using DotLiquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace ZKWeb.Plugins.Common.Base.src.TemplateTags {
	/// <summary>
	/// 设置页面描述
	/// 需要配合"render_meta_description"标签使用
	/// <example>
	/// {% use_meta_description "description" %}
	/// {% use_meta_description variable %}
	/// </example>
	/// </summary>
	public class UseMetaDescription : Tag {
		/// <summary>
		/// 设置页面描述
		/// </summary>
		public override void Render(Context context, TextWriter result) {
			var keywords = context[Markup.Trim()] ?? "";
			context.Environments[0][RenderMetaDescription.Key] = keywords; // 设置到顶级空间
		}
	}
}
