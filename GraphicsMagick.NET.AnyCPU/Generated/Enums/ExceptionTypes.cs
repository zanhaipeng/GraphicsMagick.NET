//=================================================================================================
// Copyright 2017 Dirk Lemstra <https://graphicsmagick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
using System;

namespace GraphicsMagick
{
	[Flags]
	public enum ExceptionTypes
	{
		Undefined = 0,
		EventException = 100,
		ExceptionEvent = 101,
		ResourceEvent = 102,
		ResourceLimitEvent = 102,
		TypeEvent = 105,
		AnnotateEvent = 105,
		OptionEvent = 110,
		DelegateEvent = 115,
		MissingDelegateEvent = 120,
		CorruptImageEvent = 125,
		FileOpenEvent = 130,
		BlobEvent = 135,
		StreamEvent = 140,
		CacheEvent = 145,
		CoderEvent = 150,
		ModuleEvent = 155,
		DrawEvent = 160,
		RenderEvent = 160,
		ImageEvent = 165,
		WandEvent = 167,
		TemporaryFileEvent = 170,
		TransformEvent = 175,
		XServerEvent = 180,
		X11Event = 181,
		UserEvent = 182,
		MonitorEvent = 185,
		LocaleEvent = 186,
		DeprecateEvent = 187,
		RegistryEvent = 190,
		ConfigureEvent = 195,
		WarningException = 300,
		ExceptionWarning = 301,
		ResourceWarning = 302,
		ResourceLimitWarning = 302,
		TypeWarning = 305,
		AnnotateWarning = 305,
		OptionWarning = 310,
		DelegateWarning = 315,
		MissingDelegateWarning = 320,
		CorruptImageWarning = 325,
		FileOpenWarning = 330,
		BlobWarning = 335,
		StreamWarning = 340,
		CacheWarning = 345,
		CoderWarning = 350,
		ModuleWarning = 355,
		DrawWarning = 360,
		RenderWarning = 360,
		ImageWarning = 365,
		WandWarning = 367,
		TemporaryFileWarning = 370,
		TransformWarning = 375,
		XServerWarning = 380,
		X11Warning = 381,
		UserWarning = 382,
		MonitorWarning = 385,
		LocaleWarning = 386,
		DeprecateWarning = 387,
		RegistryWarning = 390,
		ConfigureWarning = 395,
		ErrorException = 400,
		ExceptionError = 401,
		ResourceError = 402,
		ResourceLimitError = 402,
		TypeError = 405,
		AnnotateError = 405,
		OptionError = 410,
		DelegateError = 415,
		MissingDelegateError = 420,
		CorruptImageError = 425,
		FileOpenError = 430,
		BlobError = 435,
		StreamError = 440,
		CacheError = 445,
		CoderError = 450,
		ModuleError = 455,
		DrawError = 460,
		RenderError = 460,
		ImageError = 465,
		WandError = 467,
		TemporaryFileError = 470,
		TransformError = 475,
		XServerError = 480,
		X11Error = 481,
		UserError = 482,
		MonitorError = 485,
		LocaleError = 486,
		DeprecateError = 487,
		RegistryError = 490,
		ConfigureError = 495,
		FatalErrorException = 700,
		ExceptionFatalError = 701,
		ResourceFatalError = 702,
		ResourceLimitFatalError = 702,
		TypeFatalError = 705,
		AnnotateFatalError = 705,
		OptionFatalError = 710,
		DelegateFatalError = 715,
		MissingDelegateFatalError = 720,
		CorruptImageFatalError = 725,
		FileOpenFatalError = 730,
		BlobFatalError = 735,
		StreamFatalError = 740,
		CacheFatalError = 745,
		CoderFatalError = 750,
		ModuleFatalError = 755,
		DrawFatalError = 760,
		RenderFatalError = 760,
		ImageFatalError = 765,
		WandFatalError = 767,
		TemporaryFileFatalError = 770,
		TransformFatalError = 775,
		XServerFatalError = 780,
		X11FatalError = 781,
		UserFatalError = 782,
		MonitorFatalError = 785,
		LocaleFatalError = 786,
		DeprecateFatalError = 787,
		RegistryFatalError = 790,
		ConfigureFatalError = 795,
		All = 2147483647,
	}
}
