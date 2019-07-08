﻿using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class BarDataset : Dataset
    {
		/// <summary>
		/// The type of the dataset
		/// </summary>
		public Enums.ChartType Type { get; set; } = Enums.ChartType.Bar;

        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID { get; set; }

        /// <summary>
        /// The fill color of the bars.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> BackgroundColor { get; set; }

        /// <summary>
        /// Bar border color.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> BorderColor { get; set; }

        /// <summary>
        /// Border width of bar in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BorderSkipped { get; set; }

        /// <summary>
        /// Bar background color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Bar border color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> HoverBorderColor { get; set; }

        /// <summary>
        /// Border width of bar when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> HoverBorderWidth { get; set; }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack)
        /// </summary>
        public string Stack { get; set; }
    }
}
