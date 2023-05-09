const http = require('http');

const hostname = '127.0.0.1';
const port = 3000;

var connections = 0;

const server = http.createServer((req, res) => {
  connections++;
  console.log(`Number of connections surpassed: ${connections}`)
  res.statusCode = 200;
  res.setHeader('Content-Type', 'text/plain');
  res.end('Hello World');
});

server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});