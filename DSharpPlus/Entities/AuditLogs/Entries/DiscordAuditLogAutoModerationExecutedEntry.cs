// This file is part of the DSharpPlus project.
//
// Copyright (c) 2015 Mike Santiago
// Copyright (c) 2016-2025 DSharpPlus Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace DSharpPlus.Entities.AuditLogs;


public sealed class DiscordAuditLogAutoModerationExecutedEntry : DiscordAuditLogEntry
{
    /// <summary>
    /// Name of the rule that was executed
    /// </summary>
    public string ResponsibleRule { get; internal set; } = default!;

    /// <summary>
    /// User that was affected by the rule
    /// </summary>
    public DiscordUser TargetUser { get; internal set; } = default!;

    /// <summary>
    /// Type of the trigger that was executed
    /// </summary>
    public DiscordRuleTriggerType RuleTriggerType { get; internal set; }

    /// <summary>
    /// Channel where the rule was executed
    /// </summary>
    public DiscordChannel? Channel { get; internal set; }
    
    /// <summary>
    /// Id of the channel where the rule was executed
    /// </summary>
    public ulong ChannelId { get; internal set; }
}
