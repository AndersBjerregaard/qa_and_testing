import http from 'k6/http';
import { sleep } from 'k6';
import * as config from './config.js';

// k6 configuration
export const options = {
    vus: 1,
    duration: '1m',

    // Successful metric: at least 95% of requests to respond within < 1 second
    thresholds: {
        http_req_duration: ['p(95)<1000']
    },
};

export default function () {
    http.get(config.API_BASE_URL);
    sleep(1);
}