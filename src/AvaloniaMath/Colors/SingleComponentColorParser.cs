using System.Collections.Generic;
using System.Linq;
using Avalonia.Media;

namespace WpfMath.Colors
{
    /// <summary>A base class for color parsers that only require one component.</summary>
    internal abstract class SingleComponentColorParser : FixedComponentCountColorParser
    {
        protected SingleComponentColorParser() : base(1)
        {
        }

        protected abstract Color? ParseSingleComponent(string component);

        protected override Color? ParseComponents(IReadOnlyList<string> components) =>
            ParseSingleComponent(components.Single());
    }
}
