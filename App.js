import React, { useState } from 'react';
import {
  SafeAreaView,
  View,
  Text,
  FlatList,
  TouchableOpacity,
  StyleSheet,
  Image,
} from 'react-native';

// Your name:
// Your surname:
// Your student number:

const CITIES = [
  { id: '1', name: 'İstanbul' },
  { id: '2', name: 'Ankara' },
  { id: '3', name: 'İzmir' },
  { id: '4', name: 'Bursa' },
  { id: '5', name: 'Antalya' },
  { id: '6', name: 'Konya' },
  { id: '7', name: 'Trabzon' },
  { id: '8', name: 'Sivas' },
  { id: '9', name: 'Eskişehir' },
  { id: '10', name: 'Gaziantep' },
];

export default function App() {
  const [selected, setSelected] = useState({});

  const toggleCity = (id, value) => {
    setSelected((prev) => ({ ...prev, [id]: value }));
  };

  return (
    // feel the code here
  );
}

const styles = StyleSheet.create({
  container: { flex: 1, backgroundColor: '#fff', padding: 16 },
  title: { fontSize: 22, fontWeight: '700', marginTop: 20, marginBottom: 8 },
  city_image: {
    width: 48,
    height: 48,
    borderRadius: 24,
    marginRight: 12,
    overflow: 'hidden',
  },
  footer: { paddingTop: 8, paddingBottom: 16 },
  counterText: { fontSize: 18, fontWeight: '600', textAlign: 'center' },
});