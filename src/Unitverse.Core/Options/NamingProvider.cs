﻿namespace Unitverse.Core.Options
{
    using System;

    public class NamingProvider : INamingProvider
    {
        private readonly INamingOptions _namingOptions;

        public NamingProvider(INamingOptions namingOptions)
        {
            if (namingOptions is null)
            {
                throw new ArgumentNullException(nameof(namingOptions));
            }

            _namingOptions = namingOptions;
        }

        public NameResolver CanCall => new NameResolver(_namingOptions.CanCallNamingPattern);

        public NameResolver CanConstruct => new NameResolver(_namingOptions.CanConstructNamingPattern);

        public NameResolver CannotConstructWithNull => new NameResolver(_namingOptions.CannotConstructWithNullNamingPattern);

        public NameResolver CannotConstructWithInvalid => new NameResolver(_namingOptions.CannotConstructWithInvalidNamingPattern);

        public NameResolver CanGet => new NameResolver(_namingOptions.CanGetNamingPattern);

        public NameResolver CanSetAndGet => new NameResolver(_namingOptions.CanSetAndGetNamingPattern);

        public NameResolver CanSet => new NameResolver(_namingOptions.CanSetNamingPattern);

        public NameResolver ImplementsIEnumerable => new NameResolver(_namingOptions.ImplementsIEnumerableNamingPattern);

        public NameResolver ImplementsIComparable => new NameResolver(_namingOptions.ImplementsIComparableNamingPattern);

        public NameResolver PerformsMapping => new NameResolver(_namingOptions.PerformsMappingNamingPattern);

        public NameResolver CannotCallWithNull => new NameResolver(_namingOptions.CannotCallWithNullNamingPattern);

        public NameResolver CannotCallWithInvalid => new NameResolver(_namingOptions.CannotCallWithInvalidNamingPattern);

        public NameResolver CanCallOperator => new NameResolver(_namingOptions.CanCallOperatorNamingPattern);

        public NameResolver CannotCallOperatorWithNull => new NameResolver(_namingOptions.CannotCallOperatorWithNullNamingPattern);

        public NameResolver IsInitializedCorrectly => new NameResolver(_namingOptions.IsInitializedCorrectlyNamingPattern);
    }
}
