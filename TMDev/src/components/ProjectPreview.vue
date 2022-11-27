<template>
  <v-card elevation="3" width="500">
    <v-card-title v-text="project.name" class="text-center" />
    <video width="400" controls v-if="video">
      <source :src="video" type="video/mp4" />
      <img src="https://cdn.pixabay.com/photo/2022/10/19/22/15/cat-7533717_960_720.jpg" />
    </video>
    <v-card-text v-text="project.description" />
  </v-card>
</template>

<script setup lang="ts">
import api from '@/api';
import Project from '@/types/project';

const props = defineProps<{
  project: Project
}>()

const video = api.getTestVideo();
</script>

<style scoped>
  video {
    display: block;
    margin: auto;
  }
</style>
