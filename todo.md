- [ ] combine all this update todo commits together

- [ ] create or find a tool that finds all todo's in solution and puts them in a file with line numbers

- [ ] add ability to check for updates
  - [ ] popup message to user about update
  - [ ] genie type thing to show them the new features
  - [ ] maybe add a way to auto import any book that has ever been played
  - [ ] popup to tell user an update is available in the store (if they dont have auto update turned on in store)

- [ ] add multiple language support (whichever languages people ask for)

- [ ] allow user to minimize to taskbar
- [ ] should mini player and main player be allowed to both be open at the same time?

- [x] import chapters when adding audiobook to database
- [x] add progress bar when importing audiobooks
- [x] add file dialog when importing audiobooks
- [x] automatically refresh audiobooks list after importing audiobooks
- [ ] filtering:
  - [ ] add ability to see most recent
  - [ ] add filter button to change how audiobooks are sorted by default
  - [ ] show recent searches as suggestions

- [ ] add now playing bar -- in progress
  - [x] make all buttons for player work
  - [ ] make chapter combobox a fixed width

- [ ] add button to open mini audiobook player -> use OpenInNewWindow icon <FontIcon Glyph="&#xE8A7;" />
  - [ ] add check to make sure only one instance of mini player is open

- [ ] add check that verifies that the audiobooks in the database are pointing to valid files (i.e., they haven't been moved or deleted)
- [ ] fix TODO (which is a bug) in SqlAudiobookRepository.cs
- [ ] todo: update ui as each book is imported
- [ ] fix light mode
- [ ] bug when you refresh audiobooks and some of the images in the list view are blank
- [ ] create annoted scroll bar
- [ ] add support for different file types
- [ ] allow user to select accent color in settings
- [ ] disable media controls when no audiobook is opened
- [ ] only set now playing audiobook when user clicks on the play audiobook button (not when an audiobook is selected in the list view)
- [ ] fix view when no audiobooks have been imported yet
- [ ] add check to see if user has modified or deleted app files (e.g., the db file or the cover image files)
- [ ] add text underneath importing progress bar
- [ ] save playerviewmodel to DB
- [ ] allow user to change skip button amounts
  - [ ] add a setting for this
- [ ] add setting to allow user to choose to set audio for global or each book
- [ ] add setting to allow user to choose to set playback speed for global or each book

NOTES:

make a card:

```
<StackPanel 
                    CornerRadius="8"
                    Padding="12"
                    BorderThickness="1"
                    BorderBrush="{ThemeResource CardStrokeColorDefaultBrush}"
                    Background="{ThemeResource CardBackgroundFillColorDefaultBrush}">
```