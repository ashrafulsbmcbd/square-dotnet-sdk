using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class CatalogModifierList 
    {
        public CatalogModifierList(string name = null,
            int? ordinal = null,
            string selectionType = null,
            IList<Models.CatalogObject> modifiers = null)
        {
            Name = name;
            Ordinal = ordinal;
            SelectionType = selectionType;
            Modifiers = modifiers;
        }

        /// <summary>
        /// The name for the `CatalogModifierList` instance. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        /// <summary>
        /// Determines where this modifier list appears in a list of `CatalogModifierList` values.
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordinal { get; }

        /// <summary>
        /// Indicates whether a CatalogModifierList supports multiple selections.
        /// </summary>
        [JsonProperty("selection_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SelectionType { get; }

        /// <summary>
        /// The options included in the `CatalogModifierList`.
        /// You must include at least one `CatalogModifier`.
        /// Each CatalogObject must have type `MODIFIER` and contain
        /// `CatalogModifier` data.
        /// </summary>
        [JsonProperty("modifiers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.CatalogObject> Modifiers { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Name(Name)
                .Ordinal(Ordinal)
                .SelectionType(SelectionType)
                .Modifiers(Modifiers);
            return builder;
        }

        public class Builder
        {
            private string name;
            private int? ordinal;
            private string selectionType;
            private IList<Models.CatalogObject> modifiers;



            public Builder Name(string name)
            {
                this.name = name;
                return this;
            }

            public Builder Ordinal(int? ordinal)
            {
                this.ordinal = ordinal;
                return this;
            }

            public Builder SelectionType(string selectionType)
            {
                this.selectionType = selectionType;
                return this;
            }

            public Builder Modifiers(IList<Models.CatalogObject> modifiers)
            {
                this.modifiers = modifiers;
                return this;
            }

            public CatalogModifierList Build()
            {
                return new CatalogModifierList(name,
                    ordinal,
                    selectionType,
                    modifiers);
            }
        }
    }
}