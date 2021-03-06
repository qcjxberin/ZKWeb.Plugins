﻿using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWeb.Plugins.Common.Base.src.UIComponents.ListItems;
using ZKWeb.Plugins.Common.Base.src.UIComponents.ListItems.Interfaces;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Services;

namespace ZKWeb.Plugins.Shopping.Product.src.UIComponents.ListItemProviders {
	/// <summary>
	/// 商品类目的选项列表
	/// </summary>
	public class ProductCategoryListItemProvider : IListItemProvider {
		/// <summary>
		/// 获取选项列表
		/// </summary>
		/// <returns></returns>
		public IEnumerable<ListItem> GetItems() {
			var categoryManager = Application.Ioc.Resolve<ProductCategoryManager>();
			var categoryList = categoryManager.GetManyWithCache();
			foreach (var category in categoryList) {
				yield return new ListItem(new T(category.Name), category.Id.ToString());
			}
		}
	}
}
