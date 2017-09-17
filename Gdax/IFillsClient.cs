﻿using System;
using System.Threading.Tasks;
using Gdax.Models;

namespace Gdax
{
	public interface IFillsClient
	{
		/// <summary>
		///		<para>
		///			Get a list of recent fills.
		///		</para>
		///		<para>
		///			Fees are recorded in two stages. Immediately after the matching engine completes a match, the fill is inserted
		///			into the datastore. Once the fill is recorded, a settlement process will settle the fill and credit both trading
		///			counterparties.
		///		</para>
		/// </summary>
		/// <remarks>
		/// Fills are returned sorted by descending trade_id from the largest trade_id to the smallest trade_id.
		/// </remarks>
		/// <param name="orderId">Limit list of fills to this order.</param>
		/// <param name="productId">Limit list of fills to this product.</param>
		/// <param name="paging">The paging options.</param>
		/// <returns></returns>
		Task<PagedResults<Fill, Int32?>> GetFills(String orderId = null, String productId = null, PagingOptions<Int32?> paging = null);
	}
}
