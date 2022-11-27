import axios from 'axios'
import Project from './classes/project'

const api = axios.create({
  // @ts-ignore
  baseURL: import.meta.env.VITE_API_BASE
})

api.interceptors.response.use(response => response.data, error => Promise.reject(error))

export default {
  getProjects: async () => await api.get<null, Project[]>("Project/Projects"),
  getTestVideo: () => api.defaults?.baseURL + 'Project/TestVideo'
}
