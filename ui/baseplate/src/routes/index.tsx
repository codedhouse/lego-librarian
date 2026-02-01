import { createFileRoute } from '@tanstack/react-router';
import { Categories } from '../features/categories/Categories';

export const Route = createFileRoute('/')({
  component: IndexComponent,
});

function IndexComponent() {
  return <Categories />;
}
