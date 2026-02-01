import { Link } from '@tanstack/react-router';
import styles from './Header.module.css';

const navItems = [
  { label: 'home', href: '/' },
  { label: 'about', href: '/about' },
];

export const Header = () => {
  return (
    <header className={styles.appHeader}>
      <h1 className={styles.appTitle}>baseplate</h1>
      <nav>
        <ul className={styles.headerNav}>
          {navItems.map((item) => (
            <li className={styles.headerNavItem}>
              <Link to={item.href} className={styles.headerNavLink}>
                {item.label}
              </Link>
            </li>
          ))}
        </ul>
      </nav>
    </header>
  );
};
