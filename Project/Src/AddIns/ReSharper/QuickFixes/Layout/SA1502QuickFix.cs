// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SA1502QuickFix.cs" company="http://stylecop.codeplex.com">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   QuickFix - SA1502.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StyleCop.ReSharper.QuickFixes.Layout
{
    using System.Collections.Generic;

    using JetBrains.ReSharper.Feature.Services.Bulbs;
    using JetBrains.ReSharper.Feature.Services.QuickFixes;

    using StyleCop.ReSharper.BulbItems.Readability;
    using StyleCop.ReSharper.QuickFixes.Framework;
    using StyleCop.ReSharper.Violations;

    /// <summary>
    /// QuickFix - SA1502.
    /// </summary>
    //// [ShowQuickFix]
    [QuickFix]
    public class SA1502QuickFix : StyleCopQuickFixBase
    {
        /// <summary>
        /// Initializes a new instance of the SA1502QuickFix class that can 
        /// handle <see cref="StyleCopHighlightingError"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopHighlightingError"/>that has been detected.
        /// </param>
        public SA1502QuickFix(StyleCopHighlightingError highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1502QuickFix class that can handle
        /// <see cref="StyleCopHighlightingHint"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopHighlightingHint"/>that has been detected.
        /// </param>
        public SA1502QuickFix(StyleCopHighlightingHint highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1502QuickFix class that can handle
        /// <see cref="StyleCopHighlightingInfo"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopHighlightingInfo"/>that has been detected.
        /// </param>
        public SA1502QuickFix(StyleCopHighlightingInfo highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1502QuickFix class that can handle
        /// <see cref="StyleCopHighlightingSuggestion"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopHighlightingSuggestion"/>that has been detected.
        /// </param>
        public SA1502QuickFix(StyleCopHighlightingSuggestion highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1502QuickFix class that can handle
        /// <see cref="StyleCopHighlightingWarning"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopHighlightingWarning"/>that has been detected.
        /// </param>
        public SA1502QuickFix(StyleCopHighlightingWarning highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes the QuickFix with all the available BulbItems that can fix the current
        /// StyleCop Violation.
        /// </summary>
        protected override void InitialiseBulbItems()
        {
            this.BulbItems = new List<IBulbAction>
                                 {
                                     new FormatLineBulbItem
                                         {
                                             DocumentRange = this.Highlighting.CalculateRange(), 
                                             Description = "Format line : " + this.Highlighting.ToolTip
                                         }
                                 };
        }
    }
}