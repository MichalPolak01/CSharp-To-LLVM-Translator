//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dwini\Desktop\CSharpToLLVM\AntlrCSharp\CSharp.g4 by ANTLR 4.6.6

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
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, IDENTIFIER=49, LITERAL=50, WS=51;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "IDENTIFIER", 
		"LITERAL", "WS"
	};


	public CSharpLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'using'", "'static'", "';'", "'['", "'assembly'", "':'", "']'", 
		"'namespace'", "'{'", "'}'", "'partial'", "'class'", "'<'", "'>'", "'base'", 
		"'interface'", "'struct'", "'enum'", "','", "'('", "')'", "'public'", 
		"'private'", "'protected'", "'internal'", "'abstract'", "'sealed'", "'override'", 
		"'='", "'void'", "'.'", "'return'", "'if'", "'else'", "'while'", "'for'", 
		"'||'", "'&&'", "'=='", "'!='", "'>='", "'<='", "'+'", "'-'", "'*'", "'/'", 
		"'++'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "IDENTIFIER", "LITERAL", "WS"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x35\x165\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3"+
		"\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3"+
		"\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3"+
		"\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3"+
		"\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3"+
		"\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3"+
		"\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3"+
		"\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3"+
		"\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3"+
		"\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3\"\x3"+
		"\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3$\x3%\x3%\x3%\x3%\x3"+
		"&\x3&\x3&\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3)\x3)\x3)\x3*\x3*\x3*\x3+\x3+\x3"+
		"+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3\x30\x3\x31\x3\x31\x3"+
		"\x31\x3\x32\x3\x32\a\x32\x148\n\x32\f\x32\xE\x32\x14B\v\x32\x3\x33\x6"+
		"\x33\x14E\n\x33\r\x33\xE\x33\x14F\x3\x33\x3\x33\a\x33\x154\n\x33\f\x33"+
		"\xE\x33\x157\v\x33\x3\x33\x3\x33\x3\x33\x3\x33\x5\x33\x15D\n\x33\x3\x34"+
		"\x6\x34\x160\n\x34\r\x34\xE\x34\x161\x3\x34\x3\x34\x3\x155\x2\x2\x35\x3"+
		"\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2"+
		"\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12"+
		"#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33"+
		"\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43"+
		"\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]"+
		"\x2\x30_\x2\x31\x61\x2\x32\x63\x2\x33\x65\x2\x34g\x2\x35\x3\x2\x6\x5\x2"+
		"\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x3\x2\x32;\x5\x2\v\f"+
		"\xF\xF\"\"\x16A\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2"+
		"\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2"+
		"\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2"+
		"\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3"+
		"\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2"+
		"\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2"+
		"\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2"+
		"\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2"+
		"\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2"+
		"\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2"+
		"Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2"+
		"\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2"+
		"\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x3i\x3\x2\x2"+
		"\x2\x5o\x3\x2\x2\x2\av\x3\x2\x2\x2\tx\x3\x2\x2\x2\vz\x3\x2\x2\x2\r\x83"+
		"\x3\x2\x2\x2\xF\x85\x3\x2\x2\x2\x11\x87\x3\x2\x2\x2\x13\x91\x3\x2\x2\x2"+
		"\x15\x93\x3\x2\x2\x2\x17\x95\x3\x2\x2\x2\x19\x9D\x3\x2\x2\x2\x1B\xA3\x3"+
		"\x2\x2\x2\x1D\xA5\x3\x2\x2\x2\x1F\xA7\x3\x2\x2\x2!\xAC\x3\x2\x2\x2#\xB6"+
		"\x3\x2\x2\x2%\xBD\x3\x2\x2\x2\'\xC2\x3\x2\x2\x2)\xC4\x3\x2\x2\x2+\xC6"+
		"\x3\x2\x2\x2-\xC8\x3\x2\x2\x2/\xCF\x3\x2\x2\x2\x31\xD7\x3\x2\x2\x2\x33"+
		"\xE1\x3\x2\x2\x2\x35\xEA\x3\x2\x2\x2\x37\xF3\x3\x2\x2\x2\x39\xFA\x3\x2"+
		"\x2\x2;\x103\x3\x2\x2\x2=\x105\x3\x2\x2\x2?\x10A\x3\x2\x2\x2\x41\x10C"+
		"\x3\x2\x2\x2\x43\x113\x3\x2\x2\x2\x45\x116\x3\x2\x2\x2G\x11B\x3\x2\x2"+
		"\x2I\x121\x3\x2\x2\x2K\x125\x3\x2\x2\x2M\x128\x3\x2\x2\x2O\x12B\x3\x2"+
		"\x2\x2Q\x12E\x3\x2\x2\x2S\x131\x3\x2\x2\x2U\x134\x3\x2\x2\x2W\x137\x3"+
		"\x2\x2\x2Y\x139\x3\x2\x2\x2[\x13B\x3\x2\x2\x2]\x13D\x3\x2\x2\x2_\x13F"+
		"\x3\x2\x2\x2\x61\x142\x3\x2\x2\x2\x63\x145\x3\x2\x2\x2\x65\x15C\x3\x2"+
		"\x2\x2g\x15F\x3\x2\x2\x2ij\aw\x2\x2jk\au\x2\x2kl\ak\x2\x2lm\ap\x2\x2m"+
		"n\ai\x2\x2n\x4\x3\x2\x2\x2op\au\x2\x2pq\av\x2\x2qr\a\x63\x2\x2rs\av\x2"+
		"\x2st\ak\x2\x2tu\a\x65\x2\x2u\x6\x3\x2\x2\x2vw\a=\x2\x2w\b\x3\x2\x2\x2"+
		"xy\a]\x2\x2y\n\x3\x2\x2\x2z{\a\x63\x2\x2{|\au\x2\x2|}\au\x2\x2}~\ag\x2"+
		"\x2~\x7F\ao\x2\x2\x7F\x80\a\x64\x2\x2\x80\x81\an\x2\x2\x81\x82\a{\x2\x2"+
		"\x82\f\x3\x2\x2\x2\x83\x84\a<\x2\x2\x84\xE\x3\x2\x2\x2\x85\x86\a_\x2\x2"+
		"\x86\x10\x3\x2\x2\x2\x87\x88\ap\x2\x2\x88\x89\a\x63\x2\x2\x89\x8A\ao\x2"+
		"\x2\x8A\x8B\ag\x2\x2\x8B\x8C\au\x2\x2\x8C\x8D\ar\x2\x2\x8D\x8E\a\x63\x2"+
		"\x2\x8E\x8F\a\x65\x2\x2\x8F\x90\ag\x2\x2\x90\x12\x3\x2\x2\x2\x91\x92\a"+
		"}\x2\x2\x92\x14\x3\x2\x2\x2\x93\x94\a\x7F\x2\x2\x94\x16\x3\x2\x2\x2\x95"+
		"\x96\ar\x2\x2\x96\x97\a\x63\x2\x2\x97\x98\at\x2\x2\x98\x99\av\x2\x2\x99"+
		"\x9A\ak\x2\x2\x9A\x9B\a\x63\x2\x2\x9B\x9C\an\x2\x2\x9C\x18\x3\x2\x2\x2"+
		"\x9D\x9E\a\x65\x2\x2\x9E\x9F\an\x2\x2\x9F\xA0\a\x63\x2\x2\xA0\xA1\au\x2"+
		"\x2\xA1\xA2\au\x2\x2\xA2\x1A\x3\x2\x2\x2\xA3\xA4\a>\x2\x2\xA4\x1C\x3\x2"+
		"\x2\x2\xA5\xA6\a@\x2\x2\xA6\x1E\x3\x2\x2\x2\xA7\xA8\a\x64\x2\x2\xA8\xA9"+
		"\a\x63\x2\x2\xA9\xAA\au\x2\x2\xAA\xAB\ag\x2\x2\xAB \x3\x2\x2\x2\xAC\xAD"+
		"\ak\x2\x2\xAD\xAE\ap\x2\x2\xAE\xAF\av\x2\x2\xAF\xB0\ag\x2\x2\xB0\xB1\a"+
		"t\x2\x2\xB1\xB2\ah\x2\x2\xB2\xB3\a\x63\x2\x2\xB3\xB4\a\x65\x2\x2\xB4\xB5"+
		"\ag\x2\x2\xB5\"\x3\x2\x2\x2\xB6\xB7\au\x2\x2\xB7\xB8\av\x2\x2\xB8\xB9"+
		"\at\x2\x2\xB9\xBA\aw\x2\x2\xBA\xBB\a\x65\x2\x2\xBB\xBC\av\x2\x2\xBC$\x3"+
		"\x2\x2\x2\xBD\xBE\ag\x2\x2\xBE\xBF\ap\x2\x2\xBF\xC0\aw\x2\x2\xC0\xC1\a"+
		"o\x2\x2\xC1&\x3\x2\x2\x2\xC2\xC3\a.\x2\x2\xC3(\x3\x2\x2\x2\xC4\xC5\a*"+
		"\x2\x2\xC5*\x3\x2\x2\x2\xC6\xC7\a+\x2\x2\xC7,\x3\x2\x2\x2\xC8\xC9\ar\x2"+
		"\x2\xC9\xCA\aw\x2\x2\xCA\xCB\a\x64\x2\x2\xCB\xCC\an\x2\x2\xCC\xCD\ak\x2"+
		"\x2\xCD\xCE\a\x65\x2\x2\xCE.\x3\x2\x2\x2\xCF\xD0\ar\x2\x2\xD0\xD1\at\x2"+
		"\x2\xD1\xD2\ak\x2\x2\xD2\xD3\ax\x2\x2\xD3\xD4\a\x63\x2\x2\xD4\xD5\av\x2"+
		"\x2\xD5\xD6\ag\x2\x2\xD6\x30\x3\x2\x2\x2\xD7\xD8\ar\x2\x2\xD8\xD9\at\x2"+
		"\x2\xD9\xDA\aq\x2\x2\xDA\xDB\av\x2\x2\xDB\xDC\ag\x2\x2\xDC\xDD\a\x65\x2"+
		"\x2\xDD\xDE\av\x2\x2\xDE\xDF\ag\x2\x2\xDF\xE0\a\x66\x2\x2\xE0\x32\x3\x2"+
		"\x2\x2\xE1\xE2\ak\x2\x2\xE2\xE3\ap\x2\x2\xE3\xE4\av\x2\x2\xE4\xE5\ag\x2"+
		"\x2\xE5\xE6\at\x2\x2\xE6\xE7\ap\x2\x2\xE7\xE8\a\x63\x2\x2\xE8\xE9\an\x2"+
		"\x2\xE9\x34\x3\x2\x2\x2\xEA\xEB\a\x63\x2\x2\xEB\xEC\a\x64\x2\x2\xEC\xED"+
		"\au\x2\x2\xED\xEE\av\x2\x2\xEE\xEF\at\x2\x2\xEF\xF0\a\x63\x2\x2\xF0\xF1"+
		"\a\x65\x2\x2\xF1\xF2\av\x2\x2\xF2\x36\x3\x2\x2\x2\xF3\xF4\au\x2\x2\xF4"+
		"\xF5\ag\x2\x2\xF5\xF6\a\x63\x2\x2\xF6\xF7\an\x2\x2\xF7\xF8\ag\x2\x2\xF8"+
		"\xF9\a\x66\x2\x2\xF9\x38\x3\x2\x2\x2\xFA\xFB\aq\x2\x2\xFB\xFC\ax\x2\x2"+
		"\xFC\xFD\ag\x2\x2\xFD\xFE\at\x2\x2\xFE\xFF\at\x2\x2\xFF\x100\ak\x2\x2"+
		"\x100\x101\a\x66\x2\x2\x101\x102\ag\x2\x2\x102:\x3\x2\x2\x2\x103\x104"+
		"\a?\x2\x2\x104<\x3\x2\x2\x2\x105\x106\ax\x2\x2\x106\x107\aq\x2\x2\x107"+
		"\x108\ak\x2\x2\x108\x109\a\x66\x2\x2\x109>\x3\x2\x2\x2\x10A\x10B\a\x30"+
		"\x2\x2\x10B@\x3\x2\x2\x2\x10C\x10D\at\x2\x2\x10D\x10E\ag\x2\x2\x10E\x10F"+
		"\av\x2\x2\x10F\x110\aw\x2\x2\x110\x111\at\x2\x2\x111\x112\ap\x2\x2\x112"+
		"\x42\x3\x2\x2\x2\x113\x114\ak\x2\x2\x114\x115\ah\x2\x2\x115\x44\x3\x2"+
		"\x2\x2\x116\x117\ag\x2\x2\x117\x118\an\x2\x2\x118\x119\au\x2\x2\x119\x11A"+
		"\ag\x2\x2\x11A\x46\x3\x2\x2\x2\x11B\x11C\ay\x2\x2\x11C\x11D\aj\x2\x2\x11D"+
		"\x11E\ak\x2\x2\x11E\x11F\an\x2\x2\x11F\x120\ag\x2\x2\x120H\x3\x2\x2\x2"+
		"\x121\x122\ah\x2\x2\x122\x123\aq\x2\x2\x123\x124\at\x2\x2\x124J\x3\x2"+
		"\x2\x2\x125\x126\a~\x2\x2\x126\x127\a~\x2\x2\x127L\x3\x2\x2\x2\x128\x129"+
		"\a(\x2\x2\x129\x12A\a(\x2\x2\x12AN\x3\x2\x2\x2\x12B\x12C\a?\x2\x2\x12C"+
		"\x12D\a?\x2\x2\x12DP\x3\x2\x2\x2\x12E\x12F\a#\x2\x2\x12F\x130\a?\x2\x2"+
		"\x130R\x3\x2\x2\x2\x131\x132\a@\x2\x2\x132\x133\a?\x2\x2\x133T\x3\x2\x2"+
		"\x2\x134\x135\a>\x2\x2\x135\x136\a?\x2\x2\x136V\x3\x2\x2\x2\x137\x138"+
		"\a-\x2\x2\x138X\x3\x2\x2\x2\x139\x13A\a/\x2\x2\x13AZ\x3\x2\x2\x2\x13B"+
		"\x13C\a,\x2\x2\x13C\\\x3\x2\x2\x2\x13D\x13E\a\x31\x2\x2\x13E^\x3\x2\x2"+
		"\x2\x13F\x140\a-\x2\x2\x140\x141\a-\x2\x2\x141`\x3\x2\x2\x2\x142\x143"+
		"\a/\x2\x2\x143\x144\a/\x2\x2\x144\x62\x3\x2\x2\x2\x145\x149\t\x2\x2\x2"+
		"\x146\x148\t\x3\x2\x2\x147\x146\x3\x2\x2\x2\x148\x14B\x3\x2\x2\x2\x149"+
		"\x147\x3\x2\x2\x2\x149\x14A\x3\x2\x2\x2\x14A\x64\x3\x2\x2\x2\x14B\x149"+
		"\x3\x2\x2\x2\x14C\x14E\t\x4\x2\x2\x14D\x14C\x3\x2\x2\x2\x14E\x14F\x3\x2"+
		"\x2\x2\x14F\x14D\x3\x2\x2\x2\x14F\x150\x3\x2\x2\x2\x150\x15D\x3\x2\x2"+
		"\x2\x151\x155\a$\x2\x2\x152\x154\v\x2\x2\x2\x153\x152\x3\x2\x2\x2\x154"+
		"\x157\x3\x2\x2\x2\x155\x156\x3\x2\x2\x2\x155\x153\x3\x2\x2\x2\x156\x158"+
		"\x3\x2\x2\x2\x157\x155\x3\x2\x2\x2\x158\x15D\a$\x2\x2\x159\x15A\a)\x2"+
		"\x2\x15A\x15B\v\x2\x2\x2\x15B\x15D\a)\x2\x2\x15C\x14D\x3\x2\x2\x2\x15C"+
		"\x151\x3\x2\x2\x2\x15C\x159\x3\x2\x2\x2\x15D\x66\x3\x2\x2\x2\x15E\x160"+
		"\t\x5\x2\x2\x15F\x15E\x3\x2\x2\x2\x160\x161\x3\x2\x2\x2\x161\x15F\x3\x2"+
		"\x2\x2\x161\x162\x3\x2\x2\x2\x162\x163\x3\x2\x2\x2\x163\x164\b\x34\x2"+
		"\x2\x164h\x3\x2\x2\x2\b\x2\x149\x14F\x155\x15C\x161\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace AntlrCSharp
