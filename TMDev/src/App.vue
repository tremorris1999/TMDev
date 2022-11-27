<template>
  <v-app theme="dark">
    <v-navigation-drawer v-model="isNavOpen" temporary>
      <v-list nav variant="elevated">
        <v-list-item v-for="(route, i) in routes" :key="i" :value="route.name" active-color="primary" :active="isActiveRoute(route.path)"
          @click="navigate(route.path)">
          <template v-slot:prepend>
            <v-icon :icon="route.icon" />
          </template>
          <v-list-item-title v-text="route.name" />
        </v-list-item>
      </v-list>
    </v-navigation-drawer>
    <v-app-bar elevation="8">
      <v-app-bar-nav-icon icon="mdi-menu" @click.stop="toggleNav" />
    </v-app-bar>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import routes from './routes'

const isNavOpen = ref(false)
const router = useRouter();
const toggleNav = () => isNavOpen.value = !isNavOpen.value
const navigate = async (route: string) => router.push(route)
const isActiveRoute = (path: string) => router.currentRoute.value.path == path
</script>
