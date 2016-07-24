using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Migi.Framework.Helper
{
    public class MvcUI
    {
        public static List<SelectListItem> GetUsStateAbbreviationSelectList(string selectedState, bool addNoSelectionOption)
        {
            List<SelectListItem> statesSelectList = new List<SelectListItem>();

            var usStateAbbreviations = Geography.GetListOfUSStateAbbreviations();

            bool hasSelectedState = !string.IsNullOrWhiteSpace(selectedState);

            if (addNoSelectionOption)
            {
                statesSelectList.Add(new SelectListItem() { Selected = !hasSelectedState, Text = string.Empty, Value = string.Empty });
            }

            foreach (var stateAbbreviation in usStateAbbreviations)
            {
                bool selected = false;

                if (hasSelectedState && selectedState == stateAbbreviation)
                {
                    selected = true;
                }

                statesSelectList.Add(new SelectListItem() { Selected = selected, Text = stateAbbreviation, Value = stateAbbreviation });
            }
            

            return statesSelectList;
        }
        
    }
}
