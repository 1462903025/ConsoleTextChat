# ConsoleTextChat
A simple plugin letting your players chat in their game console.
# Instalation
Download the newest release and put it in your Plugins folder. (You need EXILED)
# Permissions
The only permission is ctc.mute and it's for muting and unmuting players.
# Default Config
```
console_text_chat:
  is_enabled: true
  welcome_text: Hey, did you know you can type with other people? Open your console (~ key) and use .msg <message> to talk!
  msg_wrong_usage_text: 'Wrong usage: .msg <message>'
  player_muted_response: You are muted. If you think this is a mistake, contact the server's administrator.
  mute_player_not_found: Player not found.
  player_already_muted: This player is already muted. (Did you mean .unmute?)
  player_muted_successfully: Player muted successfully!
  player_unmuted_successfully: Player unmuted successfully!
  msg_sent_successfully: Message sent successfully!
  mute_wrong_usage_text: 'Wrong usage: .mute <player>'
  unmute_wrong_usage_text: 'Wrong usage: .unmute <player>'
  player_not_muted: This player is not muted. (Did you mean .mute?)
  msg_alive_response: Only dead players can use chat.
  chat_only_when_dead: true
  display_welcome_text: true
  welcome_text_duration: 8
```
