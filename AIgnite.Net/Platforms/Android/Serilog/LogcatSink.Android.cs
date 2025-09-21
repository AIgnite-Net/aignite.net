// This file is got from:
// https://github.com/serilog-contrib/Serilog.Sinks.Logcat/blob/b515935d3622b5e11ba29fd41230929f9886ba1a/src/Serilog.Sinks.Logcat/LogcatSink.cs
// The modifications from the original (in the first commit) are:
// - Modified Emit() so that tag is now taken from the SourceContext property if it exists.
// - Added default case in Switch

using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;

namespace Serilog.Sinks.Logcat;

internal class LogcatSink: ILogEventSink
{
    private readonly string _tag;
    private readonly ITextFormatter _formatter;
    private readonly LogEventLevel _restrictedToMinimumLevel;

    public LogcatSink(
        string tag,
        ITextFormatter formatter,
        LogEventLevel restrictedToMinimumLevel)
    {
        _tag = tag ?? throw new ArgumentNullException(nameof(tag));

        _formatter = formatter;
        _restrictedToMinimumLevel = restrictedToMinimumLevel;
    }

    public void Emit(LogEvent logEvent)
    {
        if (logEvent.Level < _restrictedToMinimumLevel)
        {
            return;
        }
        
        var tag = logEvent
            .Properties
            .TryGetValue("SourceContext", out var sourceContextValue) 
                ? sourceContextValue.ToString().Replace("\"","") : _tag;
        
        using var writer = new StringWriter();

        _formatter.Format(logEvent, writer);

        var msg = writer.ToString();

        switch (logEvent.Level)
        {
            case LogEventLevel.Verbose:
                Android.Util.Log.Verbose(tag, msg);
                break;
            case LogEventLevel.Debug:
                Android.Util.Log.Debug(tag, msg);
                break;
            case LogEventLevel.Information:
            default:
                Android.Util.Log.Info(tag, msg);
                break;
            case LogEventLevel.Warning:
                Android.Util.Log.Warn(tag, msg);
                break;
            case LogEventLevel.Fatal:
            case LogEventLevel.Error:
                Android.Util.Log.Error(tag, msg);
                break;
        }
    }    
}
