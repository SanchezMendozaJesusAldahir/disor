const electron = require('electron')
const url = require('url')
const path = require('path')

const { app, BrowserWindow } = electron

let mainWindow;

app.on( 'ready', function() {
    // Create a new Window
    mainWindow = new BrowserWindow()
    //load HTML into window
    mainWindow.loadURL( url.format({
        pathname: path.join(__dirname, 'window.html'),
        protocol: 'file:',
        slashes: true
    }));
    //mainWindow.webContents.openDevTools()
});