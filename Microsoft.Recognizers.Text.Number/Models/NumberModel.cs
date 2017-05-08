﻿namespace Microsoft.Recognizers.Text.Number.Models
{
    public class NumberModel : AbstractNumberModel
    {
        public NumberModel(IParser parser, IExtractor extractor) : base(parser, extractor)
        {
        }

        public override string ModelTypeName => "number";
    }
}