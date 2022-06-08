// See https://aka.ms/new-console-template for more information

using EZ4i18n;


#region 所有动作开始前的准备工作

Translator.SetDefaultLang("中文");//设置默认语言为中文，对应 中文.txt
//设置语言文件读取路径
var langPath = Path.Join(Environment.CurrentDirectory, "Language");
Translator.SetLangPath(langPath);
//获取翻译器单例
Translator.GetInstance();

#endregion

#region 设置翻译语言并进行翻译(English)

//设置语言为 English
Translator.SetCurLang("English");//设置当前翻译语言为English，对应 English.txt
//进行翻译
Console.WriteLine("你好".Translate());//已有内容翻译
Console.WriteLine("世界".Translate());//已有内容翻译
Console.WriteLine("这是一个测试案例".Translate());//已有内容翻译
Console.WriteLine("这是".Translate());//没有内容翻译，默认返回原文字

#endregion

#region 切换翻译语言并再次进行翻译

//切换翻译语言为 正體中文
Translator.SetCurLang("正體中文");//设置当前翻译语言为English，对应 English.txt
//再次进行翻译
Console.WriteLine("你好".Translate());//已有内容翻译
Console.WriteLine("世界".Translate());//已有内容翻译
Console.WriteLine("这是一个测试案例".Translate());//已有内容翻译
Console.WriteLine("这是".Translate());//没有内容翻译，默认返回原文字

#endregion