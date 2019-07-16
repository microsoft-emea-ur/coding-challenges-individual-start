In the evolving world of command-line tools, the Windows team is always adding new features.  On top of the current shortcuts of “.” for the current folder and the “..” for the parent folder, in this problem we'll consider two new features to a standard command line path:
- The asterisk (*) will now represent the root folder.
- A list of more than 2 dots (.) will represent more of the ancestry then just the parent.  For each additional dot, you should move up one additional folder. For example “…” would represent the grandparent folder and “….” Would represent the great grandparent folder.

Given a path containing any of the current or new shortcuts, your program should normalize that path to 
the shortest possible path that contains no shortcuts.

It is noted that for this problem, a set of characters that include shortcut characters but are not the full string, 
shall be treated as a folder name. For example, a folder can be named ** or ..*, and neither * nor . 
shall be interpreted as potential shortcuts in those cases since the former contains two *s and the latter contains a 
combintation of shortcut characters that itself is not a valid shortcut.