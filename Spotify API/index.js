/* Before program can run you need to install the following:
npm install spotify-web-api-node
npm install request
npm install dotenv
*/

require('dotenv').config();
const fs = require('fs');
const SpotifyWebApi = require('spotify-web-api-node');


// Spotify API client setup
const spotifyApi = new SpotifyWebApi({
    clientId: process.env.SPOTIFY_CLIENT_ID,
    clientSecret: process.env.SPOTIFY_CLIENT_SECRET
});

// Get Spotify access token
async function initializeSpotifyApi() {
    try {
        const data = await spotifyApi.clientCredentialsGrant();
        spotifyApi.setAccessToken(data.body['access_token']);
        console.log('Spotify access token set');
    } catch (err) {
        console.error('Error retrieving Spotify access token', err);
    }
}

// Function to perform a Spotify song lookup
function lookupSong(songName) {
    spotifyApi.searchTracks(`track:${songName}`).then(
        data => {
            const song = data.body.tracks.items[0];
            if (song) {
                console.log(`Artist: ${song.artists.map(artist => artist.name).join(', ')}`);
                console.log(`Song: ${song.name}`);
                console.log(`Preview Link: ${song.preview_url}`);
                console.log(`Album: ${song.album.name}`);
            } else {
                console.log('Song not found!');
            }
        },
        err => console.error('Error fetching song:', err)
    );
}


// Function to read and execute command from a file
function readCommandFromFile(filename) {
    fs.readFile(filename, 'utf8', (err, data) => {
        if (err) {
            console.error('Error reading file:', err);
            return;
        }
        const [command, ...args] = data.trim().split(' ');
        executeCommand(command, args.join(' '));
    });
}

// Function to execute commands
function executeCommand(command, query) {
    switch (command) {
        case 'spotify':
            lookupSong(query);
            break;
        default:
            console.log('Unknown command');
    }
}

// Main logic to initialize APIs and read and execute command from 'random.txt'
initializeSpotifyApi().then(() => {
    readCommandFromFile('random.txt');
});
