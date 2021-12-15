using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Sejlklub21.Interfaces;
using Sejlklub21.Models.Chart;

namespace Sejlklub21.Pages.Statistics
{
    public class StatisticsIndexModel : PageModel
    {
        private IBookingCatalog _bookingCatalog;
        private IBoatCatalog _boatCatalog;
        private IMemberCatalog _memberCatalog;

        public ChartJs Boat { get; set; }
        public ChartJs Member { get; set; }

        public string BoatJson { get; set; }
        public string MemberJson { get; set; }
        //public Chart BoatChart { get; set; }

        public StatisticsIndexModel(IBookingCatalog bookingCatalog, IBoatCatalog boatCatalog, IMemberCatalog memberCatalog)
        {
            _bookingCatalog = bookingCatalog;
            _boatCatalog = boatCatalog;
            _memberCatalog = memberCatalog;
        }

        public void OnGet()
        {
            var data1 = from booking in _bookingCatalog.GetAllBookings()
                group booking by booking.BoatNum into boat
                orderby _boatCatalog.GetBoat(boat.Key).Name
                select boat;

            var labelsBoats = $"[{string.Join(", ", data1.Select(x => '\'' + _boatCatalog.GetBoat(x.Key).Name + '\''))}]";

            var dataBoats = $"[{string.Join(", ", data1.Select(x => x.Count()))}]";

            // Ref: https://www.chartjs.org/docs/latest/
            var chartData = $@"
        {{
            type: 'bar',
            responsive: true,
            data:
            {{
                labels: {labelsBoats},
                datasets: [{{
                    label: 'Reservationer af både',
                    data: {dataBoats},
                    borderWidth: 1
                }}]
            }},
            options:
            {{
                scales:
                {{
                    yAxes: [{{
                        ticks:
                        {{
                            beginAtZero: true
                        }}
                    }}]
                }}
            }}
        }}";

            Boat = JsonConvert.DeserializeObject<ChartJs>(chartData);
            BoatJson = JsonConvert.SerializeObject(Boat, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            });

            var data1Member = from booking in _bookingCatalog.GetAllBookings()
                group booking by booking.MemberId into member
                orderby _memberCatalog.GetMember(member.Key).Name
                select member;

            var labelsMember = $"[{string.Join(", ", data1Member.Select(x => '\'' + _memberCatalog.GetMember(x.Key).Name + '\''))}]";

            var data2Member = $"[{string.Join(", ", data1Member.Select(x => x.Count()))}]";

            // Ref: https://www.chartjs.org/docs/latest/
            var chartData2 = $@"
        {{
            type: 'bar',
            responsive: true,
            data:
            {{
                labels: {labelsMember},
                datasets: [{{
                    label: 'Reservationer ',
                    data: {data2Member},
                    borderWidth: 1
                }}]
            }},
            options:
            {{
                scales:
                {{
                    yAxes: [{{
                        ticks:
                        {{
                            beginAtZero: true
                        }}
                    }}]
                }}
            }}
        }}";

            Member = JsonConvert.DeserializeObject<ChartJs>(chartData2);
            MemberJson = JsonConvert.SerializeObject(Member, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            });
        }
    }
}
