using Humanizer;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Snippets.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HumanizedDateMarkupExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Convert.ToDateTime(Text).Humanize();
        }
    }

}
