﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace NobleMuffins.SpellingKit
{
	public interface ISampleSentence: ILocalizedItem
	{
		string BeforeTheWord { get; }
		string AfterTheWord { get; }
	}
}

