using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SubtitleFusion.Configuration;

/// <summary>
/// 插件配置
/// </summary>

public class PluginConfiguration : BasePluginConfiguration{
    /// <summary>
    /// 初始化
    /// </summary>
    public PluginConfiguration()
    {
        // 初始化
        Version = "1.0.0";
        Enable = true;
        // 名字中含有danmu的字幕文件
        MasterRegex = @"(?i).*danmu.*";
        Interval = 60;
    }

    public string Version { get; }
    /// <summary> 
    /// 是否启用
    /// </summary>
    public bool Enable { get; set; }
    /// <summary>
    /// 设置主合并字幕正则
    /// </summary>
    public string MasterRegex { get; set; }
    /// <summary>
    /// 生成任务间隔时间
    /// </summary>
    public int Interval { get; set; }
}