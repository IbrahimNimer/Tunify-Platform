# Tunify Platform

## Description

Tunify Platform is a comprehensive music management system designed to enhance the user experience in managing their music preferences. It allows users to create and manage playlists, discover new songs, and follow their favorite artists. The platform integrates a variety of features such as subscription management, playlist creation, and song organization.

## Entity-Relationship Diagram (ERD)

![Tunify ERD Diagram](Tunify.png)



## Overview of Relationships

The Tunify Platform uses several key entities, each of which is related to others in specific ways. Here is an overview of the relationships:

1. **Users**:
   - **Properties**: `UsersId`, `Username`, `Email`, `Join_Date`, `Subscription_ID`
   - **Relationships**: 
     - Each user can have one or more playlists.
     - A user is associated with a subscription.

2. **Subscription**:
   - **Properties**: `SubscriptionId`, `Subscription_Type`, `Price`
   - **Relationships**:
     - A subscription is linked to one or more users.

3. **Song**:
   - **Properties**: `SongId`, `Title`, `ArtistId`
   - **Relationships**:
     - Each song is associated with one artist.
     - Songs can be included in multiple playlists through the `PlaylistSongs` entity.

4. **PlaylistSongs**:
   - **Properties**: `PlaylistSongsId`, `PlaylistId`, `SongId`
   - **Relationships**:
     - Links a song to a specific playlist.

5. **Playlist**:
   - **Properties**: `PlaylistId`, `UsersId`, `Playlist_Name`, `Created_Date`
   - **Relationships**:
     - Each playlist is owned by a user.
     - Playlists contain multiple songs through the `PlaylistSongs` entity.

6. **Artist**:
   - **Properties**: `ArtistId`, `Name`, `Bio`
   - **Relationships**:
     - An artist can have multiple songs.
     - An artist can have multiple albums.

7. **Album**:
   - **Properties**: `AlbumId`, `Album_Name`, `Release_Date`, `ArtistId`
   - **Relationships**:
     - An album is associated with one artist.
     - Albums can contain multiple songs (though the relationship is not explicitly defined in the current model).

## Additional Information

- **Database Context**: `TunifyDbContext` is used to manage the database operations for the entities.
- **Seeding Data**: Initial data for users, artists, songs, and playlists is seeded into the database to facilitate testing and development.

For further information or to contribute to the Tunify Platform, please refer to the project's documentation or contact the development team.
