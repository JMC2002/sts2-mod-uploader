# Steam Workshop Mod

## Directory layout
* config.json -- The config describing the Steam workspace mod.
* content     -- Where you should place the mod files to be uploaded to Steam Workshop. 
                 This should be at least a PCK file, and possibly a DLL file.
* image.jpg   -- The default image. Replace with your own!
* README.md   -- This readme document

## `config.json` Properties

```
{
  "title": "",                <-- The title of your mod.
  "description": "",          <-- The description.
  "visibility": "private",    <-- The visibility status of the mod. 
                                  Options include: "private", "friends", "friendsonly", "public".
  "changeNote": "",           <-- A note for describing the newest changes you've made to your users.
  "tags": []                  <-- A list of tags to search for your mod by. 
                                  Note: the tag "tool" is reserved for mods that function as tools.
}
```





