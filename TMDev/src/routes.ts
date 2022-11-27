import HomePage from '@/pages/HomePage.vue'
import AboutPage from '@/pages/AboutPage.vue'
import ProjectsPage from '@/pages/ProjectsPage.vue'

export default [
  { path: '/', name: 'Home', component: HomePage, icon: 'mdi-home' },
  { path: '/about', name: 'About', component: AboutPage, icon: 'mdi-help' },
  { path: '/projects', name: 'Projects', component: ProjectsPage, icon: 'mdi-grease-pencil' }
]
