//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dwini\Desktop\Test2\AntlrCSharp\CSharp.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrCSharp {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CSharpLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, IDENTIFIER=29, LITERAL=30, WS=31;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "IDENTIFIER", "LITERAL", "WS"
	};


	public CSharpLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'using'", "'.'", "';'", "'static'", "'['", "'assembly'", "':'", 
		"']'", "'namespace'", "'{'", "'}'", "'class'", "'<'", "'>'", "'base'", 
		"'interface'", "'struct'", "'enum'", "','", "'('", "')'", "'='", "'void'", 
		"'return'", "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "IDENTIFIER", "LITERAL", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CSharp.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2!\xD0\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x3\x2"+
		"\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE"+
		"\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3"+
		"\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3"+
		"\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\a"+
		"\x1E\xB3\n\x1E\f\x1E\xE\x1E\xB6\v\x1E\x3\x1F\x6\x1F\xB9\n\x1F\r\x1F\xE"+
		"\x1F\xBA\x3\x1F\x3\x1F\a\x1F\xBF\n\x1F\f\x1F\xE\x1F\xC2\v\x1F\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x5\x1F\xC8\n\x1F\x3 \x6 \xCB\n \r \xE \xCC\x3 \x3 "+
		"\x3\xC0\x2\x2!\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t"+
		"\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F"+
		"\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x3\x2\x6\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x3"+
		"\x2\x32;\x5\x2\v\f\xF\xF\"\"\xD5\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2"+
		"\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF"+
		"\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2"+
		"\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2"+
		"\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2"+
		"\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2"+
		"/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x3\x41\x3\x2\x2\x2\x5G\x3\x2\x2\x2\aI\x3\x2\x2\x2\tK"+
		"\x3\x2\x2\x2\vR\x3\x2\x2\x2\rT\x3\x2\x2\x2\xF]\x3\x2\x2\x2\x11_\x3\x2"+
		"\x2\x2\x13\x61\x3\x2\x2\x2\x15k\x3\x2\x2\x2\x17m\x3\x2\x2\x2\x19o\x3\x2"+
		"\x2\x2\x1Bu\x3\x2\x2\x2\x1Dw\x3\x2\x2\x2\x1Fy\x3\x2\x2\x2!~\x3\x2\x2\x2"+
		"#\x88\x3\x2\x2\x2%\x8F\x3\x2\x2\x2\'\x94\x3\x2\x2\x2)\x96\x3\x2\x2\x2"+
		"+\x98\x3\x2\x2\x2-\x9A\x3\x2\x2\x2/\x9C\x3\x2\x2\x2\x31\xA1\x3\x2\x2\x2"+
		"\x33\xA8\x3\x2\x2\x2\x35\xAA\x3\x2\x2\x2\x37\xAC\x3\x2\x2\x2\x39\xAE\x3"+
		"\x2\x2\x2;\xB0\x3\x2\x2\x2=\xC7\x3\x2\x2\x2?\xCA\x3\x2\x2\x2\x41\x42\a"+
		"w\x2\x2\x42\x43\au\x2\x2\x43\x44\ak\x2\x2\x44\x45\ap\x2\x2\x45\x46\ai"+
		"\x2\x2\x46\x4\x3\x2\x2\x2GH\a\x30\x2\x2H\x6\x3\x2\x2\x2IJ\a=\x2\x2J\b"+
		"\x3\x2\x2\x2KL\au\x2\x2LM\av\x2\x2MN\a\x63\x2\x2NO\av\x2\x2OP\ak\x2\x2"+
		"PQ\a\x65\x2\x2Q\n\x3\x2\x2\x2RS\a]\x2\x2S\f\x3\x2\x2\x2TU\a\x63\x2\x2"+
		"UV\au\x2\x2VW\au\x2\x2WX\ag\x2\x2XY\ao\x2\x2YZ\a\x64\x2\x2Z[\an\x2\x2"+
		"[\\\a{\x2\x2\\\xE\x3\x2\x2\x2]^\a<\x2\x2^\x10\x3\x2\x2\x2_`\a_\x2\x2`"+
		"\x12\x3\x2\x2\x2\x61\x62\ap\x2\x2\x62\x63\a\x63\x2\x2\x63\x64\ao\x2\x2"+
		"\x64\x65\ag\x2\x2\x65\x66\au\x2\x2\x66g\ar\x2\x2gh\a\x63\x2\x2hi\a\x65"+
		"\x2\x2ij\ag\x2\x2j\x14\x3\x2\x2\x2kl\a}\x2\x2l\x16\x3\x2\x2\x2mn\a\x7F"+
		"\x2\x2n\x18\x3\x2\x2\x2op\a\x65\x2\x2pq\an\x2\x2qr\a\x63\x2\x2rs\au\x2"+
		"\x2st\au\x2\x2t\x1A\x3\x2\x2\x2uv\a>\x2\x2v\x1C\x3\x2\x2\x2wx\a@\x2\x2"+
		"x\x1E\x3\x2\x2\x2yz\a\x64\x2\x2z{\a\x63\x2\x2{|\au\x2\x2|}\ag\x2\x2} "+
		"\x3\x2\x2\x2~\x7F\ak\x2\x2\x7F\x80\ap\x2\x2\x80\x81\av\x2\x2\x81\x82\a"+
		"g\x2\x2\x82\x83\at\x2\x2\x83\x84\ah\x2\x2\x84\x85\a\x63\x2\x2\x85\x86"+
		"\a\x65\x2\x2\x86\x87\ag\x2\x2\x87\"\x3\x2\x2\x2\x88\x89\au\x2\x2\x89\x8A"+
		"\av\x2\x2\x8A\x8B\at\x2\x2\x8B\x8C\aw\x2\x2\x8C\x8D\a\x65\x2\x2\x8D\x8E"+
		"\av\x2\x2\x8E$\x3\x2\x2\x2\x8F\x90\ag\x2\x2\x90\x91\ap\x2\x2\x91\x92\a"+
		"w\x2\x2\x92\x93\ao\x2\x2\x93&\x3\x2\x2\x2\x94\x95\a.\x2\x2\x95(\x3\x2"+
		"\x2\x2\x96\x97\a*\x2\x2\x97*\x3\x2\x2\x2\x98\x99\a+\x2\x2\x99,\x3\x2\x2"+
		"\x2\x9A\x9B\a?\x2\x2\x9B.\x3\x2\x2\x2\x9C\x9D\ax\x2\x2\x9D\x9E\aq\x2\x2"+
		"\x9E\x9F\ak\x2\x2\x9F\xA0\a\x66\x2\x2\xA0\x30\x3\x2\x2\x2\xA1\xA2\at\x2"+
		"\x2\xA2\xA3\ag\x2\x2\xA3\xA4\av\x2\x2\xA4\xA5\aw\x2\x2\xA5\xA6\at\x2\x2"+
		"\xA6\xA7\ap\x2\x2\xA7\x32\x3\x2\x2\x2\xA8\xA9\a-\x2\x2\xA9\x34\x3\x2\x2"+
		"\x2\xAA\xAB\a/\x2\x2\xAB\x36\x3\x2\x2\x2\xAC\xAD\a,\x2\x2\xAD\x38\x3\x2"+
		"\x2\x2\xAE\xAF\a\x31\x2\x2\xAF:\x3\x2\x2\x2\xB0\xB4\t\x2\x2\x2\xB1\xB3"+
		"\t\x3\x2\x2\xB2\xB1\x3\x2\x2\x2\xB3\xB6\x3\x2\x2\x2\xB4\xB2\x3\x2\x2\x2"+
		"\xB4\xB5\x3\x2\x2\x2\xB5<\x3\x2\x2\x2\xB6\xB4\x3\x2\x2\x2\xB7\xB9\t\x4"+
		"\x2\x2\xB8\xB7\x3\x2\x2\x2\xB9\xBA\x3\x2\x2\x2\xBA\xB8\x3\x2\x2\x2\xBA"+
		"\xBB\x3\x2\x2\x2\xBB\xC8\x3\x2\x2\x2\xBC\xC0\a$\x2\x2\xBD\xBF\v\x2\x2"+
		"\x2\xBE\xBD\x3\x2\x2\x2\xBF\xC2\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC0\xBE"+
		"\x3\x2\x2\x2\xC1\xC3\x3\x2\x2\x2\xC2\xC0\x3\x2\x2\x2\xC3\xC8\a$\x2\x2"+
		"\xC4\xC5\a)\x2\x2\xC5\xC6\v\x2\x2\x2\xC6\xC8\a)\x2\x2\xC7\xB8\x3\x2\x2"+
		"\x2\xC7\xBC\x3\x2\x2\x2\xC7\xC4\x3\x2\x2\x2\xC8>\x3\x2\x2\x2\xC9\xCB\t"+
		"\x5\x2\x2\xCA\xC9\x3\x2\x2\x2\xCB\xCC\x3\x2\x2\x2\xCC\xCA\x3\x2\x2\x2"+
		"\xCC\xCD\x3\x2\x2\x2\xCD\xCE\x3\x2\x2\x2\xCE\xCF\b \x2\x2\xCF@\x3\x2\x2"+
		"\x2\b\x2\xB4\xBA\xC0\xC7\xCC\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace AntlrCSharp
