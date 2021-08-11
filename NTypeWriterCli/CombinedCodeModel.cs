﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NTypewriter.CodeModel;

namespace NTypeWriterCli
{
    public class CombinedCodeModel : ICodeModel
    {
        private List<ICodeModel> _codeModels = new();

        public CombinedCodeModel(IEnumerable<ICodeModel> codeModels)
        {
            _codeModels.AddRange(codeModels);
        }

        /// <inheritdoc />
        public IEnumerable<IClass> Classes => _codeModels.SelectMany(x => x.Classes);

        /// <inheritdoc />
        public IEnumerable<IDelegate> Delegates => _codeModels.SelectMany(x => x.Delegates);

        /// <inheritdoc />
        public IEnumerable<IEnum> Enums => _codeModels.SelectMany(x => x.Enums);

        /// <inheritdoc />
        public IEnumerable<IInterface> Interfaces => _codeModels.SelectMany(x => x.Interfaces);
    }
}
