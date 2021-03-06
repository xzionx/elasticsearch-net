﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.PutCalendar
{
	public class PutCalendarUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await PUT("/_ml/calendars/calendar_id")
			.Fluent(c => c.MachineLearning.PutCalendar("calendar_id", p => p))
			.Request(c => c.MachineLearning.PutCalendar(new PutCalendarRequest("calendar_id")))
			.FluentAsync(c => c.MachineLearning.PutCalendarAsync("calendar_id", p => p))
			.RequestAsync(c => c.MachineLearning.PutCalendarAsync(new PutCalendarRequest("calendar_id")));
	}
}
