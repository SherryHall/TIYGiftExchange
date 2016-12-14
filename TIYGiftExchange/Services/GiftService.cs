using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
//using System.Web.Http;
using System.Web;
using TIYGiftExchange.Models;
using TIYGiftExchange.Services;

namespace TIYGiftExchange.Services
{
	public class GiftService
	{
		public static List<Gift> GiftList { get; set; } = new List<Gift>();

		public static List<Gift> BuildGiftList(string currQuery)
		{
			GiftList.Clear();
			var connectionStrings = @"Server=localhost\SQLEXPRESS;Database=TIYGiftsDB;Trusted_Connection=True;";
			using (var connection = new SqlConnection(connectionStrings))
			{
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = connection;
					cmd.CommandType = System.Data.CommandType.Text;
					cmd.CommandText = @"SELECT * from Gift_Details";

					connection.Open();
					var reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						var id = reader[0];
						var contents = reader[1];
						var wrappingColor = reader[2];
						var giftHint = reader[3];
						var height = reader[4];
						var width = reader[5];
						var depth = reader[6];
						var weight = reader[7];
						var isOpened = reader.GetBoolean(8);

						var gift = new Gift
						{
							Id = (int)id,
							Contents = contents as string,
							Wrapping_Color = wrappingColor as string,
							GiftHint = giftHint as string,
							Height = (double)height,
							Width = (double)width,
							Depth = (double)depth,
							Weight = (double)weight,

							IsOpened = isOpened,

						};
						GiftList.Add(gift);
					}
					connection.Close();
				}
				return GiftList;
			}

		}
	}
}