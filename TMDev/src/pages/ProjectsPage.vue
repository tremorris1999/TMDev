<template>
  <template v-for="project in projects">
    <ProjectPreview :project="project" class="ma-auto"/>
  </template>
</template>

<script setup lang="ts">
import api from '@/api';
import Project from '@/classes/project';
import ProjectPreview from '@/components/ProjectPreview.vue';
import { onMounted, ref } from 'vue';

const projects = ref<Project[]>([])

onMounted(async () => projects.value = await api.getProjects())
</script>
