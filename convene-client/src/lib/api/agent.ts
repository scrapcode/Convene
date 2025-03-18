import axios from "axios";

// To simulate behavior during longer processing times.

const sleep = (delay: number) => {
    return new Promise(resolve => {
        setTimeout(resolve, delay)
    });
}

const agent = axios.create({
    baseURL: import.meta.env.VITE_API_URL
});

agent.interceptors.response.use(async response => {
    try {
        await sleep(1000); // To simulate behavior during longer processing times.
        return response;
    } catch (error) {
        console.log(error)
        return Promise.reject(error)
    }
});

export default agent;