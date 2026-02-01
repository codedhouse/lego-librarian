import { useEffect, useState } from 'react';
import axios from 'axios';
import { type Category } from '../../api/apiTypes';

export const Categories = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    // Fetch data
    axios
      .get('https://localhost:7210/api/categories')
      .then((res) => {
        setData(res.data);
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message);
        setLoading(false);
      });
  }, []);

  if (loading) return <div>Loading...</div>;
  if (error) return <div>Error: {error}</div>;

  return (
    <div>
      {data.map((category: Category) => (
        <p key={category.id}>{category.name}</p>
      ))}
    </div>
  );
};
