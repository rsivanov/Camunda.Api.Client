﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Group
{
    public class GroupResource
    {
		private IGroupRestService _api;
		private string _groupId;

		internal GroupResource(IGroupRestService api, string groupId)
		{
			_api = api;
			_groupId = groupId;
		}

		/// <summary>
		/// Retrieves a single group
		/// </summary>
		public Task<GroupInfo> Get() => _api.Get(_groupId);

		/// <summary>
		/// Updates a group.
		/// </summary>
		public Task Update(GroupInfo group) => _api.Update(_groupId, group);

		/// <summary>
		/// Deletes a group.
		/// </summary>
		public Task Delete() => _api.Delete(_groupId);

		public override string ToString() => _groupId;
	}
}
